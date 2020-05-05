using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOperations.Projections
{
    public class Contact
    {
        public int ContactTypeIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<Contacts, Contact>> Projection =>
            contact => new Contact()
            {
                ContactTypeIdentifier = contact.ContactId,
                FirstName = contact.FirstName,
                LastName = contact.LastName
            };
    }
}
