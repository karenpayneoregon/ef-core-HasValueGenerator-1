namespace AsyncOperations
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPerUnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedProductsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckedProductsButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.ProductsButton);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 54);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(520, 19);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(418, 19);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(96, 23);
            this.SaveChangesButton.TabIndex = 2;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(214, 19);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(96, 23);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Get Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(12, 21);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(190, 21);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessColumn,
            this.ProductNameColumn,
            this.SupplierColumn,
            this.UnitPriceColumn,
            this.QuantityPerUnitColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // ProcessColumn
            // 
            this.ProcessColumn.DataPropertyName = "Process";
            this.ProcessColumn.HeaderText = "";
            this.ProcessColumn.Name = "ProcessColumn";
            this.ProcessColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProcessColumn.Width = 25;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            this.ProductNameColumn.HeaderText = "Product";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // SupplierColumn
            // 
            this.SupplierColumn.HeaderText = "Supplier";
            this.SupplierColumn.Name = "SupplierColumn";
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.UnitPriceColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnitPriceColumn.HeaderText = "Unit price";
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            // 
            // QuantityPerUnitColumn
            // 
            this.QuantityPerUnitColumn.DataPropertyName = "QuantityPerUnit";
            this.QuantityPerUnitColumn.HeaderText = "Per unit";
            this.QuantityPerUnitColumn.Name = "QuantityPerUnitColumn";
            // 
            // CheckedProductsButton
            // 
            this.CheckedProductsButton.Location = new System.Drawing.Point(316, 19);
            this.CheckedProductsButton.Name = "CheckedProductsButton";
            this.CheckedProductsButton.Size = new System.Drawing.Size(96, 23);
            this.CheckedProductsButton.TabIndex = 4;
            this.CheckedProductsButton.Text = "Checked";
            this.CheckedProductsButton.UseVisualStyleBackColor = true;
            this.CheckedProductsButton.Click += new System.EventHandler(this.CheckedProductsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Framework Core 3: Basic DataGridView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProcessColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPerUnitColumn;
        private System.Windows.Forms.Button CheckedProductsButton;
    }
}

