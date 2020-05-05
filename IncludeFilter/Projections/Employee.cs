using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOperations.Projections
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public override string ToString() => $"{Title} {FirstName} {LastName}";
        /// <summary>
        /// This projection simplifies a lambda select
        /// </summary>
        public static Expression<Func<Employees, Employee>> Projection =>
            employee => new Employee()
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Title = employee.Title
                
            };
    }
}
