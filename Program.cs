namespace CSharp_Assignment1
{
  class Program
  {
    public static List<Student> students { get; internal set; }
    public static List<Course> courses { get; internal set; }
    static void Main(string[] args)
    {
      //Create list of students and courses
      students = new List<Student>();
      courses = new List<Course>();
      //Create object
      Course course = new Course();
      Student student = new Student();
      Presentator presentator = new Presentator();

      presentator.DisplayMenu();
      Console.WriteLine("Enter your choice: ");
      int choice;
      do
      {
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
          case 1:
            //Add new course
            course = new Course();
            course.InputInformation();
            courses.Add(course);
            presentator.DisplaySuccessfulMessage();
            presentator.DisplayMenu();
            break;
          case 2:
            //Add new student's
            student = new Student();
            student.InputInformation(courses);
            students.Add(student);
            presentator.DisplaySuccessfulMessage();
            presentator.DisplayMenu();
            break;
          case 3:
            //Display specific course information
            Console.WriteLine("Enter course's name: ");
            string courseName = Console.ReadLine();
            bool found = false;
            foreach (Course c in courses)
            {
              if (c.CourseName == courseName)
              {
                c.DisplayInformation();
                found = true;
                break;
              }
            }
            if (!found)
            {
              presentator.DisplayCourseNotExistMessage();

            }
            presentator.DisplayMenu();
            break;
          case 4:
            //Display specific student information
            Console.WriteLine("Enter student's ID: ");
            string studentID = Console.ReadLine();
            bool foundStudent = false;
            foreach (Student s in students)
            {
              if (s.StudentID == studentID)
              {
                s.DisplayInformation();
                foundStudent = true;
                break;
              }
            }
            if (!foundStudent)
            {
              presentator.DisplayStudentNotExistMessage();
            }
            presentator.DisplayMenu();
            break;
          case 5:
            HashSet<string> courseNames = new HashSet<string>();
            foreach (Course c in courses)
            {
              if (!courseNames.Contains(c.CourseName))
              {
                courseNames.Add(c.CourseName);
                c.DisplayInformation();
              }
            }
            presentator.DisplayMenu();
            break;
          case 6:
            foreach (Student s in students)
            {
              s.DisplayInformation();
            }
            presentator.DisplayMenu();
            break;
          case 7:
            student = new Student();
            Console.WriteLine("Enter student's ID: ");
            string studentIDUpdate = Console.ReadLine();
            student.UpdateInformation(studentIDUpdate);
            presentator.DisplayMenu();
            break;
          case 8:
            student = new Student();
            Console.WriteLine("Enter student's ID: ");
            string studentIDDelete = Console.ReadLine();
            student.DeleteInformation(studentIDDelete);
            presentator.DisplayMenu();
            break;
          case 9:
            presentator.Exit();
            break;
          default:
            Console.WriteLine("Invalid choice");
            break;
        }
      }
      while (choice != 9);
    }
  }
}