using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class SupplyForm : Form
    {
        public SupplyForm()
        {
            InitializeComponent();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.dBShopDataSet.Products);
            this.supplyersTableAdapter.Fill(this.dBShopDataSet.Supplyers);
        }
    }
}
