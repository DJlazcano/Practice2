using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.StudentsC
{
    public class Classroom
    {
        private List<Student> students = new List<Student>();

        //Add student instance
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        //Add student by creating a new student
        public void AddStudent(string name, int rollNumber, double mark)
        {
            students.Add(new Student(name, rollNumber, mark));
        }

        //Remove by student object
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine($"Student {student.Name} removed.\n");
        }

        //Remove by student ID
        public void RemoveStudent(int rollNumber)
        {
            Student rmStudent = students.Find(s => s.RollNumber == rollNumber);
            students.Remove(rmStudent);
            Console.WriteLine($"Student {rmStudent.Name} removed.\n");
        }

        public void ListStudents()
        {
            if (students.Count() != 0)
            {
                Console.WriteLine("List of students in the classroom:");
                foreach (Student student in students)
                {
                    student.DisplayStudentDetails();
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("No students in the classroom\n");
            }
        }
    }
}
