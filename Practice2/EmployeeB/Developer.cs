using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.EmployeeB
{
    public class Developer : Employee, IWorkable
    {
        public int YearsOfExperience { get; set; }
        public List<string> lenguages = new List<string>();

        public Developer(string name, int employeeId, double salary, int yearsOfExperience)
            : base(name, employeeId, salary)
        {
            this.YearsOfExperience = yearsOfExperience;
        }

        public void Addlenguage(string lenguage)
        {
            lenguages.Add(lenguage);
        }

        public void ListLenguages()
        {
            foreach (var l in lenguages)
            {
                Console.WriteLine(l);
            }
        }

        public void Work()
        {
            Console.WriteLine($"Developer started working at {DateTime.Now}\n");
        }

        public void TakeBreak()
        {
            Console.WriteLine($"Developer took a break at {DateTime.Now}\n");
        }

        public override string ToString()
        {
            return base.ToString() + $" Years of Experience: {YearsOfExperience}";
        }

    }
}
