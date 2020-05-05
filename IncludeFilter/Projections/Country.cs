using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOperations.Projections
{
    class Country
    {
        public int CountryIdentifier { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<Countries, Country>> Projection =>
            country => new Country()
            {
                CountryIdentifier = country.CountryIdentifier,
                Name = country.Name
            };
    }
}
