using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOperations.Projections
{
    public class ContactTypeItem
    {
        public int ContactTypeIdentifier { get; set; }
        public string ContactTitle { get; set; }

        public override string ToString() => ContactTitle;
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<ContactType, ContactTypeItem>> Projection =>
            contactType => new ContactTypeItem()
            {
                ContactTypeIdentifier = contactType.ContactTypeIdentifier,
                ContactTitle = contactType.ContactTitle

            };
    }
}
