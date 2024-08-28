using Practice2.LibraryA;
using Practice2.MusicVideoI;
using Practice2.StudentsC;
using Practice2.VehicleI;

namespace Practice2
{
    public class Program
    {

        static void Main(string[] args)
        {

            //1. Student Classes Exercise
            Console.WriteLine("1. Student Class Exercise (Classes):\n");

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
            Console.WriteLine("2. Library Exercise (Association):\n");
            Library library = new Library();

            Book book1 = new Book("Harry Potter", 1);
            Book book2 = new Book("Don Quixote", 3);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook("Game of Thrones", 10);
            library.AddBook("To Kill a Mockingbird", 5);

            library.ListBooks();

            library.RemoveBook(book1);
            library.RemoveBook(5);

            library.ListBooks();

            //3. Inheritance Exercise Vehicle
            Console.WriteLine("\n3. Vehicle exercise (Inheritance):\n");

            Car car = new Car("Nissan", "X-Trail", 2015, false, "Gas");
            Motorcycle motorcycle = new Motorcycle("BMW", "R80", 2024, "Cruiser", true);

            car.DisplayDetails();
            motorcycle.DisplayDetails();

            Console.WriteLine("\nUsing Upcasting:");
            Vehicle vehicle = car;
            vehicle.DisplayDetails();

            //4. Exercise 4 Polymorphism, Alter Vehicle add a StartEngine 
            Console.WriteLine("\n4. Vehicle Engine (Polymorphism):\n");

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car("Tesla", "Model 3", 2023, true, "Electric"));
            vehicles.Add(new Car("Nissan", "X-Trail", 2018, false, "Gasoline"));
            vehicles.Add(new Motorcycle("BMW", "X3", 2019, "Cruiser", false));
            vehicles.Add(new Motorcycle("Honda", "PCX", 2015, "Scooter", false));

            foreach (Vehicle v in vehicles)
            {
                v.DisplayDetails();
                v.StartEngine();
            }

            //5. Iinterfaces Music and Video Player
            Console.WriteLine("\n5. Music and Video Player (Interfaces):\n");

            VideoPlayer videoPlayer = new VideoPlayer();
            MusicPlayer musicPlayer = new MusicPlayer();

            musicPlayer.Play();
            videoPlayer.Play();
            videoPlayer.Pause();
            musicPlayer.Pause();

            //5. Iinterfaces Music and Video Player
            Console.WriteLine("\n6. Employee (BaseClass):\n");
        }
    }
}
