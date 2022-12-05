using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.suppliesTableAdapter.Fill(this.dBShopDataSet.Supplies);
            this.salesTableAdapter.Fill(this.dBShopDataSet.Sales);
            this.supplyersTableAdapter.Fill(this.dBShopDataSet.Supplyers);
            this.productsTableAdapter.Fill(this.dBShopDataSet.Products);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string sql;

            switch (tabControl1.SelectedTab.Text)
            {
                case "Товары":
                    {
                        ProductForm productForm = new ProductForm();

                        DialogResult result = productForm.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;

                        sql = "INSERT Products (ProductName, SupplyerId, ProductPrice, ProductQuantity) VALUES(N'"
                            + productForm.ProductNameTextBox.Text + "', " 
                            + productForm.SupplyerIdСomboBox.SelectedValue.ToString() + ", "
                            + productForm.ProductPriceNumericUpDown.Value.ToString() + ", "
                            + productForm.ProductQuantityNumericUpDown.Value.ToString() + ")\n"
                            + "SELECT * FROM Products;";
                        ExecuteSQLQuery(sql, productsDataGridView);
                        break;
                    }
                case "Продажи":
                    { 
                        SaleForm saleForm = new SaleForm();

                        DialogResult result = saleForm.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;

                        sql = "INSERT Sales (ProductId, ProductPrice, ProductQuantity, SaleDatetime) VALUES("
                            + saleForm.ProductIdСomboBox.SelectedValue.ToString() + ", " 
                            + saleForm.ProductPriceNumericUpDown.Value.ToString() + ", "
                            + saleForm.ProductQuantityNumericUpDown.Value.ToString() + ", '"
                            + saleForm.SaleDatetimePicker.Text + "')\n" +
                            "SELECT * FROM Sales;";
                        ExecuteSQLQuery(sql, salesDataGridView);
                        break;
                    }
                case "Поставки":
                    {
                        SupplyForm supplyForm = new SupplyForm();

                        DialogResult result = supplyForm.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;

                        sql = "INSERT Supplies (SupplyerId, ProductId, ProductPrice, ProductQuantity, SupplyDatetime) VALUES("
                            + supplyForm.SupplyerIdСomboBox.SelectedValue.ToString() + ", "
                            + supplyForm.ProductIdСomboBox.SelectedValue.ToString() + ", " 
                            + supplyForm.ProductPriceNumericUpDown.Value.ToString() + ", "
                            + supplyForm.ProductQuantityNumericUpDown.Value.ToString() + ", '"
                            + supplyForm.SupplyDatetimePicker.Text + "')\n"
                            + "SELECT * FROM Supplies;";
                        ExecuteSQLQuery(sql, suppliesDataGridView);
                        break;
                    }
                case "Поставщики":
                    {
                        SupplyerForm supplyerForm = new SupplyerForm();

                        DialogResult result = supplyerForm.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;

                        sql = "INSERT Supplyers (SupplyerName) VALUES(N'"
                            + supplyerForm.SupplyerNameTextBox.Text + "')\n"
                            + "SELECT * FROM Supplyers;";
                        ExecuteSQLQuery(sql, supplyersDataGridView);
                        break;
                    }
                default:
                    break;
            }           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            switch (tabControl1.SelectedTab.Text)
            {
                case "Товары":
                    {
                        if (productsDataGridView.SelectedRows.Count > 0)
                        {
                            int index = productsDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(productsDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            ProductForm productForm = new ProductForm();
                            productForm.ProductNameTextBox.Text = productsDataGridView[1, index].Value.ToString();
                            productForm.SupplyerIdСomboBox.SelectedValue = (int)productsDataGridView[2, index].Value;
                            productForm.ProductPriceNumericUpDown.Value = (decimal)productsDataGridView[3, index].Value;
                            productForm.ProductQuantityNumericUpDown.Value = (int)productsDataGridView[4, index].Value;

                            DialogResult result = productForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;

                            sql = "UPDATE TOP(1) Products SET ProductName = N'" + productForm.ProductNameTextBox.Text
                                + "', SupplyerId = " + productForm.SupplyerIdСomboBox.SelectedValue.ToString()
                                + ", ProductPrice = " + productForm.ProductPriceNumericUpDown.Value.ToString() 
                                + ", ProductQuantity = " + productForm.ProductQuantityNumericUpDown.Value.ToString()
                                + " WHERE Id = " + id + "\n" 
                                + "SELECT * FROM Products;";
                            ExecuteSQLQuery(sql, productsDataGridView);
                        }
                        break;
                    }
                case "Продажи":
                    {
                        if (salesDataGridView.SelectedRows.Count > 0)
                        {
                            int index = salesDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(salesDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            SaleForm saleForm = new SaleForm();
                            saleForm.ProductIdСomboBox.SelectedValue = salesDataGridView[1, index].Value;
                            saleForm.ProductPriceNumericUpDown.Value = (decimal)salesDataGridView[2, index].Value;
                            saleForm.ProductQuantityNumericUpDown.Value = (int)salesDataGridView[3, index].Value;
                            saleForm.SaleDatetimePicker.Text = salesDataGridView[4, index].Value.ToString();

                            DialogResult result = saleForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;

                            sql = "UPDATE TOP(1) Sales SET ProductId = " + saleForm.ProductIdСomboBox.SelectedValue.ToString()
                                + ", ProductPrice = " + saleForm.ProductPriceNumericUpDown.Value.ToString()
                                + ", ProductQuantity = " + saleForm.ProductQuantityNumericUpDown.Value.ToString()
                                + ", SaleDatetime = '" + saleForm.SaleDatetimePicker.Text
                                + "' WHERE Id = " + id + "\n"
                                + "SELECT * FROM Sales;";
                            ExecuteSQLQuery(sql, salesDataGridView);
                        }
                        break;
                    }
                case "Поставки":
                    {
                        if (suppliesDataGridView.SelectedRows.Count > 0)
                        {
                            int index = suppliesDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(suppliesDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            SupplyForm supplyForm = new SupplyForm();
                            supplyForm.SupplyerIdСomboBox.SelectedValue = suppliesDataGridView[1, index].Value;
                            supplyForm.ProductIdСomboBox.SelectedValue = suppliesDataGridView[2, index].Value;
                            supplyForm.ProductPriceNumericUpDown.Value = (decimal)suppliesDataGridView[3, index].Value;
                            supplyForm.ProductQuantityNumericUpDown.Value = (int)suppliesDataGridView[4, index].Value;
                            supplyForm.SupplyDatetimePicker.Text = suppliesDataGridView[5, index].Value.ToString();

                            DialogResult result = supplyForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;

                            sql = "UPDATE TOP(1) Supplies SET SupplyerId = " + supplyForm.SupplyerIdСomboBox.SelectedValue.ToString()
                                + ", ProductId = " + supplyForm.ProductIdСomboBox.SelectedValue.ToString()
                                + ", ProductPrice = " + supplyForm.ProductPriceNumericUpDown.Value.ToString()
                                + ", ProductQuantity = " + supplyForm.ProductQuantityNumericUpDown.Value.ToString()
                                + ", SupplyDatetime = '" + supplyForm.SupplyDatetimePicker.Text
                                + "' WHERE Id = " + id + "\n"
                                + "SELECT * FROM Supplies;";
                            ExecuteSQLQuery(sql, suppliesDataGridView);
                        }
                        break;
                    }
                case "Поставщики":
                    {
                        if (supplyersDataGridView.SelectedRows.Count > 0)
                        {
                            int index = supplyersDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(supplyersDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            SupplyerForm supplyerForm = new SupplyerForm();
                            supplyerForm.SupplyerNameTextBox.Text = supplyersDataGridView[1, index].Value.ToString();

                            DialogResult result = supplyerForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;

                            sql = "UPDATE TOP(1) Supplyers SET SupplyerName = N'" + supplyerForm.SupplyerNameTextBox.Text
                                + "' WHERE Id = " + id + "\n"
                                + "SELECT * FROM Supplyers;";
                            ExecuteSQLQuery(sql, supplyersDataGridView);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            switch (tabControl1.SelectedTab.Text)
            {
                case "Товары":
                    {
                        if (productsDataGridView.SelectedRows.Count > 0)
                        {
                            int index = productsDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(productsDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;
                           
                            sql = "DELETE TOP(1) Products"
                                + " WHERE Id = " + id + "\n"
                                + "SELECT * FROM Products;";
                            ExecuteSQLQuery(sql, productsDataGridView);
                        }
                        break;
                    }
                case "Продажи":
                    {
                        if (salesDataGridView.SelectedRows.Count > 0)
                        {
                            int index = salesDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(salesDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            sql = "DELETE TOP(1) Sales"
                                + " WHERE Id = " + id + "\n"
                                + "SELECT * FROM Sales;";
                            ExecuteSQLQuery(sql, salesDataGridView);
                        }
                        break;
                    }
                case "Поставки":
                    {
                        if (suppliesDataGridView.SelectedRows.Count > 0)
                        {
                            int index = suppliesDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(suppliesDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            sql = "DELETE TOP(1) Supplies"
                                + " WHERE Id = " + id + "\n"
                                + "SELECT * FROM Supplies;";
                            ExecuteSQLQuery(sql, suppliesDataGridView);
                        }
                        break;
                    }
                case "Поставщики":
                    {
                        if (supplyersDataGridView.SelectedRows.Count > 0)
                        {
                            int index = supplyersDataGridView.SelectedRows[0].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(supplyersDataGridView[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            sql = "DELETE TOP(1) Supplyers"
                                + " WHERE Id = " + id + "\n"
                                + "SELECT * FROM Supplyers;";
                            ExecuteSQLQuery(sql, supplyersDataGridView);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// Выполняет SQL запрос и выводить данные в указанный DataGridView
        /// </summary>
        /// <param name="sql">Строка с SQL запросом</param>
        /// <param name="dgv">DataGridView для вывода данных из таблицы базы данных</param>
        public static void ExecuteSQLQuery(string sql, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBShopConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(dataReader);
                            dgv.DataSource = dataTable;
                            dataReader.Close();
                            MessageBox.Show("Запрос выполнен.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Запрос не может быть выполнен.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
