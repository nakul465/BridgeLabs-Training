CREATE DATABASE smart_parking;

CREATE SCHEMA parking;
CREATE SCHEMA billing

CREATE TABLE parking.parking_lot(
	lot_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	lot_name TEXT NOT NULL UNIQUE,
	location TEXT NOT NULL,
	total_slots INTEGER NOT NULL CHECK(total_slots>0)
);


CREATE TABLE parking.parking_slot(
	slot_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	lot_id INTEGER NOT NULL REFERENCES parking.parking_lot(lot_id),
	slot_number VARCHAR(20) NOT NULL,
	slot_type VARCHAR(20) NOT NULL DEFAULT 'REGULAR',
	hourly_rate NUMERIC(10,2) NOT NULL CHECK(hourly_rate>=0),
	UNIQUE(lot_id,slot_number),
	CHECK (slot_type IN ('REGULAR','COMPACT','LARGE'))
);

CREATE TABLE parking.customer(
 	customer_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	customer_name TEXT NOT NULL,
	phone TEXT NOT NULL UNIQUE,
	email TEXT NOT NULL UNIQUE
)

CREATE TABLE parking.vehicle(
	vehicle_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	customer_id INTEGER REFERENCES parking.customer(customer_id),
	vehicle_number TEXT NOT NULL UNIQUE,
	vehicle_type TEXT NOT NULL,
	CHECK (vehicle_type IN ('CAR','BIKE','TRUCK'))
);

CREATE TABLE parking.parking_session(
	session_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	vehicle_id INTEGER REFERENCES parking.vehicle(vehicle_id),
	slot_id INTEGER NOT NULL REFERENCES parking.parking_slot(slot_id),
	entry_time TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	exit_time TIMESTAMP,
	status TEXT NOT NULL DEFAULT 'ACTIVE',
	CHECK (status IN ('ACTIVE','COMPLETED','CANCELLED')),
	CHECK (exit_time IS NULL OR exit_time>=entry_time)
);

CREATE TABLE billing.payment(
	payment_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	session_id INTEGER NOT NULL UNIQUE REFERENCES parking.parking_session(session_id),
	amount NUMERIC(10,2) NOT NULL CHECK(amount>=0),
	payment_time TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	payment_method TEXT NOT NULL,
	payment_status TEXT NOT NULL DEFAULT 'PAID',
	CHECK (payment_status IN ('PAID','PENDING','FAILED')),
	CHECK (payment_method IN ('CASH','CARD','UPI'))
)

CREATE TABLE parking.violations(
	violation_id INTEGER PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
	session_id INTEGER NOT NULL REFERENCES parking.parking_session(session_id),
	violation_type TEXT NOT NULL,
	violation_description TEXT,
	fine_amount NUMERIC(10,2) NOT NULL CHECK(fine_amount>=0),
	violation_time TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO parking.parking_lot
(lot_name,location,total_slots)
VALUES 
('City Mall Parking' ,'sector 10',5),
('Metro Parking','sector 1',8),
('Tech Park Parking ','sector 27',10);

INSERT INTO parking.parking_slot
(lot_id,slot_number,slot_type,hourly_rate)
VALUES
(1,'A1','REGULAR',40),
(1,'A2','REGULAR',40),
(1,'A3','COMPACT',30),
(1,'A4','LARGE',50),
(1,'A5','LARGE',45),

(2,'B1','REGULAR',40),
(2,'B2','REGULAR',40),
(2,'B3','COMPACT',40),
(2,'B4','LARGE',40),

(3,'C1','REGULAR',40),
(3,'C2','REGULAR',40),
(3,'C3','LARGE',40),
(3,'C4','COMPACT',40),
(3,'C5','LARGE',40),
(3,'C6','COMPACT',40);


INSERT INTO parking.customer
(customer_name,phone,email)
VALUES
('Nakul Arora','9255294455','nakul@gmail.com'),
('Manish Bansal','9213230678','manish@gmail.com'),
('Rahul Verma','9587647589','rahul@gmail.com'),
('Amit Kumar','9567456345','amit@gmail.com');

INSERT INTO parking.vehicle
(customer_id,vehicle_number,vehicle_type)
VALUES
(1,'HR10AM5024','CAR'),
(1,'HR10AN9024','CAR'),
(2,'HR69R3456','TRUCK'),
(3,'HR10AL3213','BIKE'),
(4,'HR10AL4546','BIKE');


INSERT INTO parking.parking_session
(vehicle_id, slot_id, entry_time, exit_time, status)
VALUES
(1, 1, '2026-09-28 08:00:00', '2026-09-28 10:00:00', 'COMPLETED'),
(2, 5, '2026-09-28 09:00:00', '2026-09-28 12:00:00', 'COMPLETED'),
(3, 6, '2026-09-28 10:00:00', '2026-09-28 14:00:00', 'COMPLETED'),
(4, 7, '2026-09-28 11:00:00', '2026-09-28 12:00:00', 'COMPLETED');

INSERT INTO billing.payment
(session_id, amount, payment_method, payment_status)
VALUES
(1, 80,  'UPI',  'PAID'),
(2, 135, 'CARD', 'PAID'),
(3, 140, 'CASH', 'PAID'),
(4, 35,  'UPI',  'PAID');


select * from parking.vehicle

--Trigger preventing two active sessions from using the same parking slot.
CREATE OR REPLACE FUNCTION parking.prevent_duplicate_active_slot()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN

    IF NEW.status = 'ACTIVE' THEN
        IF EXISTS (
            SELECT 1
            FROM parking.parking_session
            WHERE slot_id = NEW.slot_id
              AND status = 'ACTIVE'
              AND session_id <> COALESCE(NEW.session_id, -1)
        ) THEN
            RAISE EXCEPTION'Parking slot  is already occupied';
        END IF;
    END IF;
    RETURN NEW;
	
END;
$$;

CREATE TRIGGER trg_prevent_duplicate_slot
BEFORE INSERT OR UPDATE
ON parking.parking_session
FOR EACH ROW
EXECUTE FUNCTION parking.prevent_duplicate_active_slot();

--UDF to calculate parking charges based on entry and exit time.
CREATE OR REPLACE FUNCTION billing.calculate_parking_charge(
	p_entry TIMESTAMP,
	p_exit TIMESTAMP,
	p_hourly_rate NUMERIC
)
RETURNS NUMERIC
LANGUAGE plpgsql
AS $$
DECLARE 
	hours NUMERIC;
BEGIN 
	hours := (EXTRACT(EPOCH FROM (p_exit-p_entry))/3600);
	RETURN (hours * p_hourly_rate);
END;
$$;


--Stored procedure to create a parking session.
CREATE OR REPLACE PROCEDURE parking.create_parking_session(
	p_vehicle_id INTEGER,
	p_slot_id INTEGER
)
LANGUAGE plpgsql
AS $$ 
DECLARE 
	existing INTEGER;
BEGIN 
	SELECT slot_id INTO existing 
	FROM parking.parking_slot
	WHERE slot_id=p_slot_id
	FOR UPDATE;

	IF existing is NULL THEN 
		RAISE EXCEPTION 'Parking doesnt exit';
	END IF;

	IF EXISTS(
		SELECT 1 FROM parking.parking_session
		WHERE slot_id=p_slot_id AND status='ACTIVE'
	)THEN 
		RAISE EXCEPTION 'Parking is already occupied';
	END IF;

	INSERT INTO parking.parking_session
	(vehicle_id,slot_id,entry_time,status)
	VALUES
	(p_vehicle_id,p_slot_id,CURRENT_TIMESTAMP,'ACTIVE');
END;
$$;

CALL parking.create_parking_session(3,3);
SELECT * FROM parking.parking_session


--Joins to display active parking sessions.
SELECT ps.session_id,v.vehicle_number,c.customer_name,ps.entry_time,ps.status
FROM parking.parking_session ps
JOIN parking.vehicle v
	ON ps.vehicle_id=v.vehicle_id
JOIN parking.customer c
	ON v.customer_id=c.customer_id
WHERE ps.status='ACTIVE'


--CTE to calculate parking-lot occupancy.
WITH occupied AS
(
	SELECT pslot.lot_id,COUNT(*) AS occupied_slots
	FROM parking.parking_session ps
	JOIN parking.parking_slot pslot
		ON ps.slot_id=pslot.slot_id
	WHERE ps.status='ACTIVE'
	GROUP BY pslot.lot_id
)
SELECT pl.lot_id,pl.lot_name,pl.total_slots,
	   COALESCE(o.occupied_slots,0) AS occupied_slots,
	   pl.total_slots-COALESCE(o.occupied_slots,0) AS available_slots,
	   COALESCE(o.occupied_slots,0)*100.0/pl.total_slots AS occupancy_percentage
FROM parking.parking_lot pl
LEFT JOIN occupied o
	ON pl.lot_id=o.lot_id;



--Subquery to identify customers whose parking expenditure is above average.
SELECT c.customer_id, c.customer_name, SUM(p.amount) AS total_expenditure
FROM parking.customer c
JOIN parking.vehicle v
    ON c.customer_id = v.customer_id
JOIN parking.parking_session ps
    ON v.vehicle_id = ps.vehicle_id
JOIN billing.payment p
    ON ps.session_id = p.session_id
WHERE p.payment_status = 'PAID'
GROUP BY c.customer_id, c.customer_name
HAVING SUM(p.amount)>(
	SELECT AVG(customer_total)
	FROM(
		SELECT SUM(p.amount) AS customer_total
		FROM parking.customer c
		JOIN parking.vehicle v
		    ON c.customer_id = v.customer_id
		JOIN parking.parking_session ps
		    ON v.vehicle_id = ps.vehicle_id
		JOIN billing.payment p
		    ON ps.session_id = p.session_id
		WHERE p.payment_status = 'PAID'
		GROUP BY c.customer_id, c.customer_name
	)AS expenditure
);


--Temporary table containing currently occupied slots.
CREATE TEMP TABLE occupied_slots AS
SELECT  pslot.slot_id, pslot.slot_number, pslot.lot_id, ps.session_id, ps.vehicle_id, ps.entry_time
FROM parking.parking_slot pslot
JOIN parking.parking_session ps
	ON pslot.slot_id=ps.slot_id
WHERE status='ACTIVE';


--View for available parking slots.
CREATE OR REPLACE VIEW parking.available_slots AS
SELECT pslot.slot_id, pl.lot_name, pl.location, pslot.slot_number, pslot.slot_type, pslot.hourly_rate
FROM parking.parking_slot pslot
JOIN parking.parking_lot pl
    ON pslot.lot_id = pl.lot_id
WHERE NOT EXISTS
(
    SELECT 1
    FROM parking.parking_session ps
    WHERE ps.slot_id = pslot.slot_id
      AND ps.status = 'ACTIVE'
);

--Create indexes on vehicle number, parking slot and session timestamps.
CREATE INDEX idx_vehicle_number
ON parking.vehicle(vehicle_number);

CREATE INDEX idx_parking_slot
ON parking.parking_slot(slot_id);

CREATE INDEX idx_session_entry_time
ON parking.parking_session(entry_time);

CREATE INDEX idx_session_exit_time
ON parking.parking_session(exit_time);

CREATE INDEX idx_session_timestamps
ON parking.parking_session(entry_time, exit_time);

--Demonstrate transaction and row-level locking during slot allocation.
BEGIN;

SELECT *
FROM parking.parking_slot
WHERE slot_id = 1
FOR UPDATE;

SELECT *
FROM parking.parking_session
WHERE slot_id = 1
  AND status = 'ACTIVE';

INSERT INTO parking.parking_session
(vehicle_id,slot_id,entry_time,status)
VALUES
(2,1,CURRENT_TIMESTAMP,'ACTIVE');

COMMIT;

--Create a role for parking operators and use DCL commands to provide only the required permissions
CREATE ROLE parking_operator
LOGIN
PASSWORD 'StrongPassword123';

GRANT USAGE
ON SCHEMA parking
TO parking_operator;

GRANT USAGE
ON SCHEMA billing
TO parking_operator;

GRANT SELECT
ON parking.parking_lot,
   parking.parking_slot,
   parking.vehicle,
   parking.customer,
   parking.parking_session
TO parking_operator;

GRANT INSERT, UPDATE
ON parking.parking_session
TO parking_operator;