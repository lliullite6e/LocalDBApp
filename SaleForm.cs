using System.Windows.Forms;

namespace Shop
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, System.EventArgs e)
        {
            this.productsTableAdapter.Fill(this.dBShopDataSet.Products);
        }
    }
}
