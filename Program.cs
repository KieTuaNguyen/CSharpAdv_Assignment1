namespace CSharp_Assignment1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Create object
      Teacher teacher = new Teacher();
      Student student = new Student();
      Presentator presentator = new Presentator();

      //Menu
      presentator.DisplayMenu();

      Console.WriteLine("Enter your choice: ");
      int choice;
      do
      {
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
          case 1:
            Console.WriteLine("Enter teacher's ID: ");
            teacher.TeacherID = Console.ReadLine();
            Console.WriteLine("Enter teacher's name: ");
            teacher.Name = Console.ReadLine();
            Console.WriteLine("Enter teacher's email: ");
            teacher.Email = Console.ReadLine();
            Console.WriteLine("Enter teacher's courses: ");
            teacher.Courses = Console.ReadLine().Split(',').ToList();
            Console.WriteLine("Enter teacher's date of birth: ");
            teacher.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter teacher's phone: ");
            teacher.Phone = Console.ReadLine();
            Console.WriteLine("Enter teacher's address: ");
            teacher.Address = Console.ReadLine();
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine(" The information is added successfully");
            Console.WriteLine(" -------------------------------------");
            presentator.DisplayMenu();
            break;
          case 2:
            Console.WriteLine("Enter student's ID: ");
            student.StudentID = Console.ReadLine();
            Console.WriteLine("Enter student's name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student's email: ");
            student.Email = Console.ReadLine();
            Console.WriteLine("Enter student's courses: ");
            student.Courses = Console.ReadLine().Split(',').ToList();
            Console.WriteLine("Enter student's date of birth: ");
            student.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's phone: ");
            student.Phone = Console.ReadLine();
            Console.WriteLine("Enter student's address: ");
            student.Address = Console.ReadLine();
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine(" The information is added successfully");
            Console.WriteLine(" -------------------------------------");
            presentator.DisplayMenu();
            break;
          case 3:
            teacher.DisplayInformation();
            presentator.DisplayMenu();
            break;
          case 4:
            student.DisplayInformation();
            presentator.DisplayMenu();
            break;
          case 5:
            Console.WriteLine("Exit");
            break;
          default:
            Console.WriteLine("Please re-enter your choice (from 1-5):");
            break;
        }
      }
      while (choice != 5);
    }
  }
}