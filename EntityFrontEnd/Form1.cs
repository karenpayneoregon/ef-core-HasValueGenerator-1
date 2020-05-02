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

        private async void AddCustomersButton_Click(object sender, EventArgs e)
        {

            var result = await HelperOperations.AddCustomers();

            MessageBox.Show(result ?
                "Add range successful" :
                "Add range failed");

        }

        private async void ResetAccountNumberButton_Click(object sender, EventArgs e)
        {
            var result = await HelperOperations.ResetAccountNumber();

            MessageBox.Show(result ? 
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
