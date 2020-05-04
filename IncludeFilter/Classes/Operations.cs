using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncOperations.Projections;
using Microsoft.EntityFrameworkCore;

namespace AsyncOperations.Classes
{
    public class Operations
    {
        private static readonly NorthWindContext _northWindContext = new NorthWindContext();
        public static NorthWindContext Context => _northWindContext;
        public static async Task<List<Category>> GetCategoriesAsync()
        {
            var categoryList = new List<Category>();

            await Task.Run(async () =>
            {

                categoryList = await _northWindContext.Categories
                    .AsNoTracking().Select(Category.Projection)
                    .ToListAsync();

            });

            return categoryList;
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

                supplierList = await _northWindContext.Suppliers
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

                productList = await _northWindContext.Products
                    .Include(product => product.Supplier)
                    .Where(product => product.CategoryId == categoryIdentifier)
                    .ToListAsync();

            });

            return productList;
        }
    }
}
