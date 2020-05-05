using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AsyncOperations.ModelExtensions
{
    public static class QueryExtensions
    {
        /// <summary>
        /// Include order details
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static IQueryable<Orders> IncludeDetails(this IQueryable<Orders> query) 
        {
            return query.Include(orders => orders.OrderDetails);
        }

        public static IQueryable<Orders> IncludeCustomer(this IQueryable<Orders> query)
        {
            return query.Include(orders => orders.CustomerIdentifierNavigation);
        }
        public static IQueryable<Orders> IncludeCustomerAndContact(this IQueryable<Orders> query)
        {
            return query.Include(orders => orders.CustomerIdentifierNavigation)
                .ThenInclude(customer => customer.Contact)
                .Include(orders => orders.CustomerIdentifierNavigation.ContactTypeIdentifierNavigation);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="contact">Include contact information</param>
        /// <param name="contactType">Include contact type information</param>
        /// <returns></returns>
        public static IQueryable<Orders> IncludeOptions(this IQueryable<Orders> query, bool contact = false, bool contactType = false)
        {
            IQueryable<Orders> customerQuery = query.Include(order => order.CustomerIdentifierNavigation);
            if (contact)
            {
                customerQuery = customerQuery.Include(order => order.CustomerIdentifierNavigation.Contact);
            }

            if (contactType)
            {
                customerQuery = customerQuery.Include(order =>
                    order.CustomerIdentifierNavigation.ContactTypeIdentifierNavigation);
            }

            return customerQuery;
        }
    }
}
