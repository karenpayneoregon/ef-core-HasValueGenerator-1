using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncOperations;
using Microsoft.EntityFrameworkCore;

namespace AsyncOperations.Classes
{
    public class Operations
    {
        private static readonly NorthWindContext _northWindContext = new NorthWindContext();
        public static NorthWindContext Context => _northWindContext;
        public static async Task<List<Categories>> GetCategoriesAsync()
        {
            var categoryList = new List<Categories>();

            await Task.Run(async () =>
            {

                categoryList = await _northWindContext.Categories
                    .AsNoTracking()
                    .ToListAsync();

            });

            return categoryList;
        }

        public static async Task<List<Supplier>> GetSupplierAsync() 
        {
            var categoryList = new List<Supplier>();

            await Task.Run(async () =>
            {

                categoryList = await _northWindContext.Suppliers
                    .AsNoTracking()
                    .Select(suppliers => new Supplier() {SupplierId = suppliers.SupplierId, CompanyName = suppliers.CompanyName})
                    .ToListAsync();

            });

            return categoryList;
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
