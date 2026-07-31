using System;
namespace OOPS
{
	public class HotelBooking
	{
		string guestName;
		string roomType;
		int nights;
		public HotelBooking()
		{
			this.guestName = "Ram";
			this.roomType = "Deluxe";
			this.nights = 1;
		}
		public HotelBooking(string guestName,string roomType,int nights)
		{
			this.guestName = guestName;
			this.roomType = roomType;
			this.nights = nights;
		}
        public HotelBooking(HotelBooking h1)
        {
            this.guestName = h1.guestName;
            this.roomType = h1.roomType;
            this.nights = h1.nights;
        }
    }
}

