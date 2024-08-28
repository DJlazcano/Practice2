using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.EmployeeB
{
    public class Employee
    {
        
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int employeeId, double salary)
        {
            Name = name;
            EmployeeId = employeeId;
            Salary = salary;
        }

        public override string ToString() => $"Employee Name: {Name} | EmployeeId: {EmployeeId}";
    }
}
