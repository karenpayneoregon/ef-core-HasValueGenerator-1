using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrontEnd.Classes;
using EntityOperations;

namespace EntityFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomerDataGridView.AutoGenerateColumns = false;
        }

        private void AddCustomersButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelperOperations.AddCustomers() ? 
                "Add range successful" : 
                "Add range failed");
        }

        private void ResetAccountNumberButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelperOperations.ResetAccountNumber() ? 
                "Reset finished" : 
                "Reset failed");
        }

        private async void ViewCustomersButton_Click(object sender, EventArgs e)
        {
            var customers = await HelperOperations.GetCustomers();
            CustomerDataGridView.DataSource = customers;
        }
    }
}
