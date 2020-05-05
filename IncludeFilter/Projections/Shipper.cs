using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOperations.Projections
{
    public class Shipper
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<Shippers, Shipper>> Projection =>
            shipper => new Shipper()
            {
                SupplierId = shipper.ShipperId,
                Name = shipper.CompanyName
            };
    }
}
