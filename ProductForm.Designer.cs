namespace Shop
{
    partial class ProductForm
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dBShopDataSet = new Shop.DBShopDataSet();
            this.dBShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyersTableAdapter = new Shop.DBShopDataSetTableAdapters.SupplyersTableAdapter();
            this.dBShopDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplyersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplyersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SupplyerIdСomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(13, 172);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ок";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(133, 172);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(133, 12);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTextBox.TabIndex = 6;
            // 
            // ProductPriceNumericUpDown
            // 
            this.ProductPriceNumericUpDown.Location = new System.Drawing.Point(133, 92);
            this.ProductPriceNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ProductPriceNumericUpDown.Name = "ProductPriceNumericUpDown";
            this.ProductPriceNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ProductPriceNumericUpDown.TabIndex = 11;
            // 
            // ProductQuantityNumericUpDown
            // 
            this.ProductQuantityNumericUpDown.Location = new System.Drawing.Point(133, 132);
            this.ProductQuantityNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            this.ProductQuantityNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ProductQuantityNumericUpDown.TabIndex = 12;
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
            this.supplyersBindingSource.DataSource = this.dBShopDataSet;
            // 
            // supplyersTableAdapter
            // 
            this.supplyersTableAdapter.ClearBeforeFill = true;
            // 
            // dBShopDataSetBindingSource1
            // 
            this.dBShopDataSetBindingSource1.DataSource = this.dBShopDataSet;
            this.dBShopDataSetBindingSource1.Position = 0;
            // 
            // supplyersBindingSource1
            // 
            this.supplyersBindingSource1.DataMember = "Supplyers";
            this.supplyersBindingSource1.DataSource = this.dBShopDataSetBindingSource1;
            // 
            // supplyersBindingSource2
            // 
            this.supplyersBindingSource2.DataMember = "Supplyers";
            this.supplyersBindingSource2.DataSource = this.dBShopDataSetBindingSource;
            // 
            // SupplyerIdСomboBox
            // 
            this.SupplyerIdСomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplyersBindingSource, "SupplyerName", true));
            this.SupplyerIdСomboBox.DataSource = this.supplyersBindingSource;
            this.SupplyerIdСomboBox.DisplayMember = "SupplyerName";
            this.SupplyerIdСomboBox.FormattingEnabled = true;
            this.SupplyerIdСomboBox.Location = new System.Drawing.Point(131, 52);
            this.SupplyerIdСomboBox.Name = "SupplyerIdСomboBox";
            this.SupplyerIdСomboBox.Size = new System.Drawing.Size(102, 21);
            this.SupplyerIdСomboBox.TabIndex = 13;
            this.SupplyerIdСomboBox.ValueMember = "Id";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 211);
            this.Controls.Add(this.SupplyerIdСomboBox);
            this.Controls.Add(this.ProductQuantityNumericUpDown);
            this.Controls.Add(this.ProductPriceNumericUpDown);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "ProductForm";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBShopDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox ProductNameTextBox;
        protected internal System.Windows.Forms.NumericUpDown ProductPriceNumericUpDown;
        protected internal System.Windows.Forms.NumericUpDown ProductQuantityNumericUpDown;
        private System.Windows.Forms.BindingSource dBShopDataSetBindingSource;
        private DBShopDataSet dBShopDataSet;
        private System.Windows.Forms.BindingSource supplyersBindingSource;
        private DBShopDataSetTableAdapters.SupplyersTableAdapter supplyersTableAdapter;
        private System.Windows.Forms.BindingSource dBShopDataSetBindingSource1;
        private System.Windows.Forms.BindingSource supplyersBindingSource1;
        private System.Windows.Forms.BindingSource supplyersBindingSource2;
        protected internal System.Windows.Forms.ComboBox SupplyerIdСomboBox;
    }
}