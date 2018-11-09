/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Transport_System
 * Bus class
 * Registration number: 
 * Date: 
 -----------------------------------------------------------------------------------------*/

namespace BUSE_Transport_System
{
	public class Bus : Vehicle
	{
		private byte seats;
        private bool airConditioning;

		public Bus( string inventoryNumber, 
                    uint acquisitionYear, 
                    Colors color, 
                    uint regChk, 
                    byte seats, 
                    bool airConditioning )
          : base(inventoryNumber, acquisitionYear, color, regChk)
        {
            this.seats = seats;
            this.airConditioning = airConditioning;

        }

		public byte Seats
		{
			get
			{
                return seats;
			}
		}

        public bool HasAirConditioning
        {
            get
            {
                return airConditioning;
            } 
            set 
            {
                airConditioning = value;
            }
        }

    }
}
