using System;
using static AsyncOperations.Classes.Dialogs;
using System.Windows.Forms;
using AsyncOperations.Classes;

namespace AsyncOperations.Examples
{
    public partial class ExamplesForm : Form
    {

        public ExamplesForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Best, only load what's needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadProjectsButton_Click(object sender, EventArgs e)
        {
            var categories = await Operations.GetCategoriesAllProjectionsAsync();
            CategoryProjectionsAsynComboBox.DataSource = categories;
        }
        /// <summary>
        /// Loads more properties than needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadWithoutProjectsButton_Click(object sender, EventArgs e)
        {
            var categories = await Operations.GetCategoriesAllNoProjectionsAsync();
            CategoryProjectionsAsynComboBox.DataSource = categories;
        }
        /// <summary>
        /// Potentially freezes for a few seconds if this is the first read via EF Core.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConventionalLoadButton_Click(object sender, EventArgs e)
        {
            var categories = Operations.GetCategoriesAllNotTracked();
            CategoryConventionalComboBox.DataSource = categories;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations.GetOrders();
        }
    }
}
