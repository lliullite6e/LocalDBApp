namespace Shop
{
    partial class SupplyForm
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
            this.ProductPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SupplyDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductIdСomboBox = new System.Windows.Forms.ComboBox();
            this.SupplyerIdСomboBox = new System.Windows.Forms.ComboBox();
            this.dBShopDataSet = new Shop.DBShopDataSet();
            this.dBShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyersTableAdapter = new Shop.DBShopDataSetTableAdapters.SupplyersTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Shop.DBShopDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPriceNumericUpDown
            // 
            this.ProductPriceNumericUpDown.Location = new System.Drawing.Point(133, 88);
            this.ProductPriceNumericUpDown.Name = "ProductPriceNumericUpDown";
            this.ProductPriceNumericUpDown.Size = new System.Drawing.Size(132, 20);
            this.ProductPriceNumericUpDown.TabIndex = 31;
            // 
            // ProductQuantityNumericUpDown
            // 
            this.ProductQuantityNumericUpDown.Location = new System.Drawing.Point(133, 126);
            this.ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            this.ProductQuantityNumericUpDown.Size = new System.Drawing.Size(132, 20);
            this.ProductQuantityNumericUpDown.TabIndex = 30;
            // 
            // SupplyDatetimePicker
            // 
            this.SupplyDatetimePicker.CustomFormat = "MM.dd.yyyy";
            this.SupplyDatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SupplyDatetimePicker.Location = new System.Drawing.Point(133, 164);
            this.SupplyDatetimePicker.Name = "SupplyDatetimePicker";
            this.SupplyDatetimePicker.Size = new System.Drawing.Size(132, 20);
            this.SupplyDatetimePicker.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Дата и время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Поставщик";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(133, 202);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(13, 202);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 23;
            this.BtnOk.Text = "Ок";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Товар";
            // 
            // ProductIdСomboBox
            // 
            this.ProductIdСomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "ProductName", true));
            this.ProductIdСomboBox.DataSource = this.productsBindingSource;
            this.ProductIdСomboBox.DisplayMember = "ProductName";
            this.ProductIdСomboBox.FormattingEnabled = true;
            this.ProductIdСomboBox.Location = new System.Drawing.Point(133, 50);
            this.ProductIdСomboBox.Name = "ProductIdСomboBox";
            this.ProductIdСomboBox.Size = new System.Drawing.Size(132, 21);
            this.ProductIdСomboBox.TabIndex = 34;
            this.ProductIdСomboBox.ValueMember = "Id";
            // 
            // SupplyerIdСomboBox
            // 
            this.SupplyerIdСomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplyersBindingSource, "SupplyerName", true));
            this.SupplyerIdСomboBox.DataSource = this.supplyersBindingSource;
            this.SupplyerIdСomboBox.DisplayMember = "SupplyerName";
            this.SupplyerIdСomboBox.FormattingEnabled = true;
            this.SupplyerIdСomboBox.Location = new System.Drawing.Point(133, 12);
            this.SupplyerIdСomboBox.Name = "SupplyerIdСomboBox";
            this.SupplyerIdСomboBox.Size = new System.Drawing.Size(132, 21);
            this.SupplyerIdСomboBox.TabIndex = 35;
            this.SupplyerIdСomboBox.ValueMember = "Id";
            // 
            // dBShopDataSet
            // 
            this.dBShopDataSet.DataSetName = "DBShopDataSet";
            this.dBShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBShopDataSetBindingSource
            // 
            this.dBShopDataSetBindingSource.DataSource = this.dBShopDataSet;
            this.dBShopDataSetBindingSource.Position = 0;
            // 
            // supplyersBindingSource
            // 
            this.supplyersBindingSource.DataMember = "Supplyers";
            this.supplyersBindingSource.DataSource = this.dBShopDataSetBindingSource;
            // 
            // supplyersTableAdapter
            // 
            this.supplyersTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dBShopDataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.SupplyerIdСomboBox);
            this.Controls.Add(this.ProductIdСomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPriceNumericUpDown);
            this.Controls.Add(this.ProductQuantityNumericUpDown);
            this.Controls.Add(this.SupplyDatetimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "SupplyForm";
            this.Text = "SupplyForm";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.NumericUpDown ProductPriceNumericUpDown;
        protected internal System.Windows.Forms.NumericUpDown ProductQuantityNumericUpDown;
        protected internal System.Windows.Forms.DateTimePicker SupplyDatetimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.ComboBox ProductIdСomboBox;
        protected internal System.Windows.Forms.ComboBox SupplyerIdСomboBox;
        private System.Windows.Forms.BindingSource dBShopDataSetBindingSource;
        private DBShopDataSet dBShopDataSet;
        private System.Windows.Forms.BindingSource supplyersBindingSource;
        private DBShopDataSetTableAdapters.SupplyersTableAdapter supplyersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DBShopDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}