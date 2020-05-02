namespace EntityFrontEnd
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
            this.AddCustomersButton = new System.Windows.Forms.Button();
            this.ResetAccountNumberButton = new System.Windows.Forms.Button();
            this.ViewCustomersButton = new System.Windows.Forms.Button();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCustomersButton
            // 
            this.AddCustomersButton.Location = new System.Drawing.Point(12, 168);
            this.AddCustomersButton.Name = "AddCustomersButton";
            this.AddCustomersButton.Size = new System.Drawing.Size(181, 23);
            this.AddCustomersButton.TabIndex = 0;
            this.AddCustomersButton.Text = "Add Customers";
            this.AddCustomersButton.UseVisualStyleBackColor = true;
            this.AddCustomersButton.Click += new System.EventHandler(this.AddCustomersButton_Click);
            // 
            // ResetAccountNumberButton
            // 
            this.ResetAccountNumberButton.Location = new System.Drawing.Point(225, 168);
            this.ResetAccountNumberButton.Name = "ResetAccountNumberButton";
            this.ResetAccountNumberButton.Size = new System.Drawing.Size(181, 23);
            this.ResetAccountNumberButton.TabIndex = 1;
            this.ResetAccountNumberButton.Text = "Reset Account number";
            this.ResetAccountNumberButton.UseVisualStyleBackColor = true;
            this.ResetAccountNumberButton.Click += new System.EventHandler(this.ResetAccountNumberButton_Click);
            // 
            // ViewCustomersButton
            // 
            this.ViewCustomersButton.Location = new System.Drawing.Point(438, 168);
            this.ViewCustomersButton.Name = "ViewCustomersButton";
            this.ViewCustomersButton.Size = new System.Drawing.Size(181, 23);
            this.ViewCustomersButton.TabIndex = 2;
            this.ViewCustomersButton.Text = "View customers";
            this.ViewCustomersButton.UseVisualStyleBackColor = true;
            this.ViewCustomersButton.Click += new System.EventHandler(this.ViewCustomersButton_Click);
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToAddRows = false;
            this.CustomerDataGridView.AllowUserToDeleteRows = false;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.CustomerDataGridView.Location = new System.Drawing.Point(12, 12);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersVisible = false;
            this.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDataGridView.Size = new System.Drawing.Size(613, 138);
            this.CustomerDataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Identifier";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "AccountNumber";
            this.Column2.HeaderText = "Account";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CompanyName";
            this.Column3.HeaderText = "Company";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ContactName";
            this.Column4.HeaderText = "Contact";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ContactType";
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gender";
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 211);
            this.Controls.Add(this.CustomerDataGridView);
            this.Controls.Add(this.ViewCustomersButton);
            this.Controls.Add(this.ResetAccountNumberButton);
            this.Controls.Add(this.AddCustomersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF Core: HasValueGenerator on Add sample";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCustomersButton;
        private System.Windows.Forms.Button ResetAccountNumberButton;
        private System.Windows.Forms.Button ViewCustomersButton;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

