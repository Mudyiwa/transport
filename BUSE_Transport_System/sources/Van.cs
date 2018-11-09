/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Transport_System
 * Van class
 * Registration number: 
 * Date: 
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Transport_System
{
	public class Van : Vehicle
	{
        VanSize size;

		public Van( string inventoryNumber, 
                    uint acquisitionYear, 
                    Colors color, 
                    uint regChk,
                    VanSize size )
          : base(inventoryNumber, acquisitionYear, color, regChk)
        {
            this.size = size;
		}

		public VanSize Size
		{
			get {
                return size;
			}
		}
	}
}
