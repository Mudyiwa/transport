/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Transport_System
 * BUSE_TransportSystem class
 * Registration number: 
 * Date: 
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Transport_System
{
	public class BUSE_TransportSystem
	{
        // Attributes...
		string[] drivers;
        int drivers_count;
        Vehicle[] vehicles;
        int vehicles_count;

        // Constructor...
		public BUSE_TransportSystem()
		{
			drivers = new string[100];
            vehicles = new Vehicle[100];
            drivers_count = vehicles_count = 0;
		}

        // Others methods..
		public void AddVehicle(Vehicle v)
		{
            if (vehicles.Length < vehicles_count)
            {
                vehicles[vehicles_count++] = v;
            }
            else
                throw new Exception("The vehicles' array is full");
		}

		public void AddDriver(string name)
		{
            if (drivers.Length < drivers_count)
            {
                drivers[drivers_count++] = name;
            }
            else
                throw new Exception("The drivers array is full");
        }
	}
}
