using System.Windows.Forms;

namespace Shop
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, System.EventArgs e)
        {
            this.supplyersTableAdapter.Fill(this.dBShopDataSet.Supplyers);
        }
    }
}
