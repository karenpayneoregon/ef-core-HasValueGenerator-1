using System;
using System.Collections.Generic;

namespace AsyncOperations
{
    public partial class Contacts
    {
        public Contacts()
        {
            Customers = new HashSet<Customers>();
        }

        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}