using System;
using System.Linq.Expressions;

namespace AsyncOperations.Projections
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public override string ToString() => CategoryName;
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<Categories, Category>> Projection =>
            category => new Category()
            {
                CategoryId =  category.CategoryId,
                CategoryName = category.CategoryName
            };
    }
}
