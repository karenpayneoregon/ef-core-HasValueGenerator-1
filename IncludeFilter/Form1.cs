using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncOperations.Classes;
using AsyncOperations.Components;
using Microsoft.EntityFrameworkCore;

namespace AsyncOperations 
{
    public partial class Form1 : Form
    {
        private SortableBindingList<Products> _productView;
        private BindingSource _productBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            ProductsButton.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            Shown += Form1_Shown;

        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            var categories = await Operations.GetCategoriesAsync();
            CategoryComboBox.DataSource = categories;
            ProductsButton.Enabled = true;

            
        }
        /// <summary>
        /// React to changes for the current product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _productView_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {

                /*
                 * Access deleted products
                 */
                var deleted = Operations.Context.ChangeTracker.Entries()
                    .Where(item => item.State == EntityState.Deleted).Select(item => item.Entity as Products).ToList();

            }

            var currentProduct = _productView[_productBindingSource.Position];

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                Console.WriteLine(Operations.Context.Entry(currentProduct).State);
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
            }
        }

        /// <summary>
        /// Do not load all products, only products which belong to the
        /// selected category in the ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ProductsButton_Click(object sender, EventArgs e)
        {
            var categoryIdentifier = ((Categories) CategoryComboBox.SelectedItem).CategoryId;

            try
            {
                _productView = new SortableBindingList<Products>(await Operations.GetProducts(categoryIdentifier));
                //_productView.ListChanged -= _productView_ListChanged;
                _productView.ListChanged += _productView_ListChanged;
                _productBindingSource.DataSource = _productView;
                dataGridView1.DataSource = _productBindingSource;
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Operations.Context.Entry(_productView[e.Row.Index]).State = EntityState.Deleted;
        }
    }
}
