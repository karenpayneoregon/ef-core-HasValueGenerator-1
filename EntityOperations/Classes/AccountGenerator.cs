using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace EntityOperations.Classes
{ 
    public class AccountGenerator : ValueGenerator<string>
    {
        public override bool GeneratesTemporaryValues => false;

        private readonly CustomerContext _context;

        public AccountGenerator()
        {
            _context = new CustomerContext();
        }
        public override string Next(EntityEntry entry)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get current value, increment, save and return new generated value
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        protected override object NextValue(EntityEntry entry)
        {
            var lastAccountValue = _context.NewAccountTable.FirstOrDefault()?.CustomerAccountNumber;

            /*
             * Recycle
             */
            if (lastAccountValue == null) return "A0000";

            var currentValue = Increment.AlphaNumericValue(lastAccountValue);
            var customer = _context.NewAccountTable.FirstOrDefault();

            if (customer == null) return currentValue;

            customer.CustomerAccountNumber = currentValue;
            _context.SaveChanges();
            
            return currentValue;
        }
    }
}