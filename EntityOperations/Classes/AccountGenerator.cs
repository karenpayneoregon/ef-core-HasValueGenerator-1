using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
        /// <summary>
        /// Get current account number from table and increment by 1
        /// </summary>
        /// <returns>Next account number or recycle back to first alpha number</returns>
        private string NextAccountNumber()
        {
            var lastAccountValue = _context.NewAccountTable
                .AsNoTracking()
                .FirstOrDefault()?.CustomerAccountNumber;

            if (lastAccountValue == null)
            {
                return "A0000";
            }

            var currentValue = Increment.AlphaNumericValue(lastAccountValue);
            var accountTable = _context.NewAccountTable.FirstOrDefault();

            if (accountTable == null) return currentValue;

            accountTable.CustomerAccountNumber = currentValue;

            _context.SaveChanges();

            return currentValue;
        }

        /// <summary>
        /// Template method to perform value generation for AccountNumber.
        /// </summary>
        /// <param name="entry">In this case Customer</param>
        /// <returns>Current account number</returns>
        public override string Next(EntityEntry entry) => NextAccountNumber();
        /// <summary>
        /// Gets a value to be assigned to AccountNumber property
        /// </summary>
        /// <param name="entry">In this case Customer</param>
        /// <returns>Current account number</returns>
        protected override object NextValue(EntityEntry entry) => NextAccountNumber();
    }
}