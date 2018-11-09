using System;
using System.Windows.Forms;

namespace BUSE_Transport_System
{
    public partial class MainForm : Form
    {
        // Attributes...
        BUSE_TransportSystem myTransportSystem;

        public MainForm()
        {
            InitializeComponent();
            myTransportSystem = new BUSE_TransportSystem();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the application ?";
            const string caption = "Application Closing";
            var result = MessageBox.Show(message, caption,
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            // If the "yes" button was pressed ... exit the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUSE Transport System. \nTeam work Leo and Walter",
                             "BUSE TS",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private void newVanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewVan f; // Declaring the form to  capture the data...
            f = new NewVan(); // Creating the form ...
            // If the user click on the IOk button...
            if ( f.ShowDialog() == DialogResult.OK) {
                // Ask if he/she really wants to add the van
                if (MessageBox.Show("Do you want to add the new van?",
                                  "BUSE Transport System",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.Yes)
                    myTransportSystem.AddVehicle(
                     new Van(f.Inventory_Number,
                              f.AcquisitionYear,
                              f.VanColor,
                              f.CheckUpDistance,
                              f.VanSize));
            }
        }
    }
}
