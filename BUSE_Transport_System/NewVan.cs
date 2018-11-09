using System.Windows.Forms;

namespace BUSE_Transport_System
{
    public partial class NewVan : Form
    {

        public NewVan()
        {
            InitializeComponent();
        }

        public string Make {
          get {
                return tb_make.Text;
            }
        }

        public VanSize VanSize {
          get {
                return (VanSize)lb_size.SelectedItem;
            }
        }

        public string Model {
            get {
                return tb_model.Text;
            }
        }

        public string Inventory_Number
        {
            get {
                return tb_inventorynumber.Text;
            }
        }

        public Colors VanColor {
           get {
                return (Colors)lb_color.SelectedItem;
           }
        }

        public uint CheckUpDistance {
          get {
                return uint.Parse(tb_chekup_dist.Text);
          }
        }

        public uint AcquisitionYear
        {
            get
            {
                return uint.Parse(tb_acquisitionYear.Text);
            }
        }


    }


}
