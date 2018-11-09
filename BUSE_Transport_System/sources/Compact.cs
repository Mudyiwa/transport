/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Transport_System
 * Compact class
 * Registration number: 
 * Date: 
 -----------------------------------------------------------------------------------------*/

namespace BUSE_Transport_System
{
	public class Compact : Vehicle
	{
        // Attributes
		private VanSize size;

        // Constructor
		public Compact( string inventoryNumber, 
                        uint acquisitionYear, 
                        Colors color, 
                        uint regChk, 
                        VanSize size )
          : base(inventoryNumber,acquisitionYear,color,regChk)
		{
            this.size = size; ;
		}

		public VanSize Size
		{
			get
			{
                return size;
			}
		}
	}
}
