using System;
using System.Linq.Expressions;

namespace AsyncOperations.Projections
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public override string ToString() => CompanyName;
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<Suppliers, Supplier>> Projection =>
            supplier => new Supplier()
            {
                SupplierId = supplier.SupplierId,
                CompanyName = supplier.CompanyName
            };
    }
}
