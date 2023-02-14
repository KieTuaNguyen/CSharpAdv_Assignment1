namespace CSharp_Assignment1
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create list of teacher and student
      List<Teacher> teachers = new List<Teacher>();
      List<Student> students = new List<Student>();

      //Create presentator object
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
            Teacher teacher = new Teacher();
            teacher.InputInformation();
            teachers.Add(teacher);
            presentator.DisplayMenu();
            break;
          case 2:
            Student student = new Student();
            student.InputInformation();
            students.Add(student);
            presentator.DisplayMenu();
            break;
          case 3:
            foreach (Teacher t in teachers)
            {
              t.DisplayInformation();
            }
            presentator.DisplayMenu();
            break;
          case 4:
            foreach (Student s in students)
            {
              s.DisplayInformation();
            }
            presentator.DisplayMenu();
            break;
          case 5:
            Console.WriteLine("Exit the program");
            break;
          default:
            Console.WriteLine("Invalid choice");
            break;
        }
      }
      while (choice != 5);
    }
    //   static void Main(string[] args)
    //   {
    //     //Create greenwich object
    //     School greenwich = new SchoolBuilder(3)
    //       .SetClassrooms()
    //       .SetLibrary()
    //       .SetTenisCourt()
    //       .SetSwimmingPool()
    //       .Build();
    //     Console.WriteLine(greenwich.GetSchoolInfo());
    //     Console.WriteLine("---");
    //     //Create dut object
    //     School dut = new SchoolBuilder(5)
    //       .SetClassrooms()
    //       .SetLibrary()
    //       .Build();
    //     Console.WriteLine(dut.GetSchoolInfo());
    //   }
  }
}