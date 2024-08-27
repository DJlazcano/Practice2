using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.StudentsC
{
    public class Student
    {
        public string Name { get; set; }

        public int RollNumber { get; set; }

        public string Grade { get; set; }


        //Create student without a Mark/Grade
        public Student(string name, int rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
        }

        //Create a student with a Mark and generate a Grade
        public Student(string name, int rollNumber, double mark)
        {
            Name = name;
            RollNumber = rollNumber;
            CalculateGrade(mark);
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Roll Number: {RollNumber}, Grade: {Grade}");
        }

        public void CalculateGrade(double mark)
        {
            Grade = mark >= 80 ? "A" :
                mark >= 65 ? "B" :
                mark >= 50 ? "C" :
                mark >= 40 ? "D" : "F";
        }

    }
}
