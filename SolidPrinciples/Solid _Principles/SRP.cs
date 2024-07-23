using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid__Principles
{
    internal class SRP
    {
        // Example with SRP
        public class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }

        public class EmployeeDataAccess
        {
            public void SaveEmployee(Employee emp)
            {
                // Save employee details to database
            }
        }

        public class PayrollProcessor
        {
            public void GeneratePaySlip(Employee emp)
            {
                // Generate pay slip logic
            }

            public void CalculateTax(Employee emp)
            {
                // Calculate tax logic
            }
        }
    }
}
