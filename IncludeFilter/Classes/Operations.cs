using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncOperations.ModelExtensions;
using AsyncOperations.Projections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace AsyncOperations.Classes
{
    public class Operations
    {
        private static readonly NorthWindContext NorthWindContext = new NorthWindContext(); 
        public static NorthWindContext Context => NorthWindContext;

        /// <summary>
        /// Get all categories suitable for displaying in a ComboBox or
        /// ListBox for reference only with only properties needed e.g.
        /// primary key and product name
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Category>> GetCategoriesAllProjectionsAsync()
        {
            var categoryList = new List<Category>();

            await Task.Run(async () =>
            {

                categoryList = await NorthWindContext.Categories
                    .AsNoTracking().Select(Category.Projection)
                    .ToListAsync();

            });

            return categoryList;

        }
        /// <summary>
        /// Get all categories suitable for displaying in a ComboBox or
        /// ListBox for reference only but unlike above will have all properties
        /// of Categories table.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Categories>> GetCategoriesAllNoProjectionsAsync() 
        {
            var categoryList = new List<Categories>();

            await Task.Run(async () =>
            {

                categoryList = await NorthWindContext.Categories
                    .AsNoTracking()
                    .ToListAsync();

            });

            return categoryList;

        }
        public static List<Categories> GetCategoriesAllNotTracked()
        {

            return NorthWindContext.Categories
                .AsNoTracking()
                .ToList();

        }
        public static List<Categories> GetCategoriesAllTracked()
        {
            return NorthWindContext.Categories
                .ToList();
        }

        /// <summary>
        /// Get list of supplier which is assigned to a private form variable
        /// and used when products for a specific category are selected in the form.
        ///
        /// Note the use of a Project for selecting suppliers in the select part
        /// of the lambda statement.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Supplier>> GetSupplierAsync() 
        {
            var supplierList = new List<Supplier>(); 

            await Task.Run(async () =>
            {

                supplierList = await NorthWindContext.Suppliers
                    .AsNoTracking()
                    .Select(Supplier.Projection)
                    .ToListAsync();

            });

            return supplierList;
        }

        public static async Task<List<Products>> GetProducts(int categoryIdentifier, bool throwException = false)
        {
            var productList = new List<Products>();

            await Task.Run(async () =>
            {

                if (throwException)
                {
                    var lines = File.ReadAllLines("SomeNonExistingFile.txt");
                }

                productList = await NorthWindContext.Products
                    .Include(product => product.Supplier)
                    .Where(product => product.CategoryId == categoryIdentifier)
                    .ToListAsync();

            });

            return productList;
        }
        /// <summary>
        /// Using extension methods
        /// </summary>
        public static async void GetOrders()
        {

            await Task.Run(async () =>
            {
                var orders1 = await NorthWindContext.Orders
                    .IncludeDetails()
                    .IncludeCustomer()
                    .FirstOrDefaultAsync(x => x.CustomerIdentifier == 10);

                var orders2 = await NorthWindContext.Orders
                    .IncludeCustomerAndContact()
                    .FirstOrDefaultAsync(x => x.CustomerIdentifier == 10);

                var order3 = await NorthWindContext.Orders.IncludeOptions(contact: true, contactType: true).FirstOrDefaultAsync();



            });


        }
    }
}
