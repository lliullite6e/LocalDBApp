namespace Shop
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SaleDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductIdСomboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBShopDataSet = new Shop.DBShopDataSet();
            this.productsTableAdapter = new Shop.DBShopDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата и время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Товар";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(140, 174);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(20, 174);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "Ок";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // SaleDatetimePicker
            // 
            this.SaleDatetimePicker.CustomFormat = "MM.dd.yyyy";
            this.SaleDatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SaleDatetimePicker.Location = new System.Drawing.Point(140, 134);
            this.SaleDatetimePicker.Name = "SaleDatetimePicker";
            this.SaleDatetimePicker.Size = new System.Drawing.Size(132, 20);
            this.SaleDatetimePicker.TabIndex = 19;
            // 
            // ProductQuantityNumericUpDown
            // 
            this.ProductQuantityNumericUpDown.Location = new System.Drawing.Point(140, 94);
            this.ProductQuantityNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            this.ProductQuantityNumericUpDown.Size = new System.Drawing.Size(132, 20);
            this.ProductQuantityNumericUpDown.TabIndex = 20;
            // 
            // ProductPriceNumericUpDown
            // 
            this.ProductPriceNumericUpDown.Location = new System.Drawing.Point(140, 54);
            this.ProductPriceNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ProductPriceNumericUpDown.Name = "ProductPriceNumericUpDown";
            this.ProductPriceNumericUpDown.Size = new System.Drawing.Size(132, 20);
            this.ProductPriceNumericUpDown.TabIndex = 21;
            // 
            // ProductIdСomboBox
            // 
            this.ProductIdСomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "ProductName", true));
            this.ProductIdСomboBox.DataSource = this.productsBindingSource;
            this.ProductIdСomboBox.DisplayMember = "ProductName";
            this.ProductIdСomboBox.FormattingEnabled = true;
            this.ProductIdСomboBox.Location = new System.Drawing.Point(140, 14);
            this.ProductIdСomboBox.Name = "ProductIdСomboBox";
            this.ProductIdСomboBox.Size = new System.Drawing.Size(132, 21);
            this.ProductIdСomboBox.TabIndex = 22;
            this.ProductIdСomboBox.ValueMember = "Id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dBShopDataSetBindingSource;
            // 
            // dBShopDataSetBindingSource
            // 
            this.dBShopDataSetBindingSource.DataSource = this.dBShopDataSet;
            this.dBShopDataSetBindingSource.Position = 0;
            // 
            // dBShopDataSet
            // 
            this.dBShopDataSet.DataSetName = "DBShopDataSet";
            this.dBShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.ProductIdСomboBox);
            this.Controls.Add(this.ProductPriceNumericUpDown);
            this.Controls.Add(this.ProductQuantityNumericUpDown);
            this.Controls.Add(this.SaleDatetimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "SaleForm";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        protected internal System.Windows.Forms.DateTimePicker SaleDatetimePicker;
        protected internal System.Windows.Forms.NumericUpDown ProductQuantityNumericUpDown;
        protected internal System.Windows.Forms.NumericUpDown ProductPriceNumericUpDown;
        protected internal System.Windows.Forms.ComboBox ProductIdСomboBox;
        private System.Windows.Forms.BindingSource dBShopDataSetBindingSource;
        private DBShopDataSet dBShopDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DBShopDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}