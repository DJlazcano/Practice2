using Practice2.StudentsC;

namespace Practice2
{
    public class Program
    {

        static void Main(string[] args)
        {

            //1. Student Classes Exercise
            Console.WriteLine("Student Class Exercise:\n");

            Classroom classroom = new Classroom();

            Student juan = new Student("Juan", 65730);
            juan.CalculateGrade(95);

            juan.DisplayStudentDetails();

            Student john = new Student("John", 45390, 70);
            Student harold = new Student("Harold", 549904, 50);

            classroom.AddStudent(juan);
            classroom.AddStudent(john);
            classroom.AddStudent(harold);
            classroom.AddStudent("Alonso", 30309, 25);

            classroom.ListStudents();

            classroom.RemoveStudent(juan);
            classroom.RemoveStudent(30309);

            classroom.ListStudents();

            //2. Library Asociation Exercise

        }
    }
}
