using System;
namespace OOPS
{
	public class CarRental
	{
		string customerName;
		string carModel;
		int rentalDays;
		int rent;
		public CarRental()
		{
			this.customerName = "Ram";
			this.carModel = "Lexus";
			this.rentalDays = 30;
			this.rent = 3000;
		}
        public CarRental(string customerName,string carModel,int rentalDays,int rent)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
			this.rent = rent;
        }
		public int totalCost()
		{
			return rentalDays * rent;
		}
    }
}

