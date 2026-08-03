using System;
using System.Net.NetworkInformation;

namespace Inheritance
{
	public class Device
	{
		public int DeviceId;
		public string Status;
        public Device(int DeviceId,string Status)
		{
			this.DeviceId = DeviceId;
			this.Status = Status;
		}
		public virtual void DisplayStatus()
		{
			Console.WriteLine($"\nDeviceId : {DeviceId}\nStatus : {Status}");
		}

    }
	class Thermostat: Device
	{
		string TemperatureSetting;
		public Thermostat(int DeviceId, string Status, string TemperatureSetting) : base(DeviceId, Status)
		{
			this.TemperatureSetting = TemperatureSetting;
        }
        public override void DisplayStatus()
        {
            Console.WriteLine($"\nDeviceId : {DeviceId}\nStatus : {Status}\nTemperatureSetting : {TemperatureSetting}");
        }

    }
}

