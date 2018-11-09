/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Transport_System
 * Vehicle class
 * Registration number: 
 * Date: 
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Transport_System
{
	public class Vehicle
	{
        // Attributes
		private Colors color;
		private uint acquisitionYear;
		private string inventoryNumber;
		private uint regularChk;

        // Constructor
		public Vehicle( string inventoryNumber, 
                        uint acquisitionYear, 
                        Colors color, 
                        uint regChk )
		{
            this.inventoryNumber = inventoryNumber;
            this.acquisitionYear = acquisitionYear;
            this.color = color;
            regularChk = regChk;
		}

        // Properties...

		public Colors Color
		{
			get
			{
                return color;
			}
			set
			{
                color = value;
			}
		}

		public uint AcquisitionYear
		{
			get
			{
                return acquisitionYear;
			}
		}

		public String InventoryNumber
		{
			get
			{
                return inventoryNumber;
			}
		}

		public uint RegularCheckUpDistance
		{
			get
			{
                return regularChk;
			}
			set
			{
                regularChk = value;

            }
		}
	}
}
