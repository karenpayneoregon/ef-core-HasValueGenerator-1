using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityOperations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrontEnd.Classes
{
    public class HelperOperations
    {
        /// <summary>
        /// Reset account number
        /// </summary>
        /// <returns></returns>
        public static bool ResetAccountNumber()
        {
            using (var context = new CustomerContext())
            {
                context.NewAccountTable.FirstOrDefault().CustomerAccountNumber = "A0000";
                return context.SaveChanges() == 1;
            }
        }
        /// <summary>
        /// Add four mocked up customers, set account number
        /// </summary>
        /// <returns></returns>
        public static bool AddCustomers()
        {
            using (var context = new CustomerContext())
            {
                context.AddRange(MockedData.Customers());
                return  context.SaveChanges() == 4;
            }
        }
        /// <summary>
        /// Get customers
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Customer>> GetCustomers()
        {
            var customers = new List<Customer>();

            await Task.Run(async () =>
            {
                using (var context = new CustomerContext())
                {
                    customers = await context.Customer
                        .AsNoTracking()
                        .Include(customer => customer.ContactTypeIdentifierNavigation)
                        .Include(customer => customer.GenderIdentifierNavigation)
                        .ToListAsync();
                }
            });

            return customers;
        }
    }
}
