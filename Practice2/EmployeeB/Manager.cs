using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.EmployeeB
{
    public class Manager : Employee, IWorkable
    {
        public int TeamSize { get; set; }
        public string Department { get; set; }

        public List<Employee> Team = new List<Employee>();

        public Manager(string name, int employeeId, double salary)
            : base(name, employeeId, salary) { }

        public void AddMemeber(Employee employee)
        {
            Team.Add(employee);
            TeamSize++;
        }

        public void ListTeam()
        {
            Console.WriteLine("Team members:");
            foreach (Employee emp in Team) {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("\n");
        }

        public void Work()
        {
            Console.WriteLine($"Manager started working at {DateTime.Now}\n");
        }

        public void TakeBreak()
        {
            Console.WriteLine($"Manager took a break at {DateTime.Now}\n");
        }

        public override string ToString()
        {
            return base.ToString() + $" Team Size: {TeamSize}";
        }
    }
}
