namespace CSharp_Assignment1
{
  class Student : IPerson
  {
    public Student()
    {
      Courses = new List<Course>();
    }

    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string StudentID { get; set; }
    public List<Course> Courses { get; set; }

    //Overirde methods 
    public void DisplayInformation()
    {
      Console.WriteLine("=========STUDENT INFORMATION=========");
      Console.WriteLine(" |Name: " + Name);
      Console.WriteLine(" |Email: " + Email);
      Console.WriteLine(" |Date of Birth: " + DateOfBirth.ToString("dd/MM/yyyy"));
      Console.WriteLine(" |Student ID: " + StudentID);
      Console.WriteLine(" |Courses: " + string.Join(", ", Courses));
      Console.WriteLine("=====================================");
    }

    //Method
    public void InputInformation(List<Course> courses)
    {
      bool uniqueID = false;
      while (!uniqueID)
      {
        Console.WriteLine("Enter student's ID: ");
        StudentID = Console.ReadLine();

        // Check if the student ID already exists
        bool studentIDExists = Program.students.Any(s => s.StudentID == StudentID);
        if (!studentIDExists)
        {
          uniqueID = true;
        }
        else
        {
          Console.WriteLine("Student ID already exists. Please re-enter.");
        }
      }
      Console.WriteLine("Enter student's name: ");
      Name = Console.ReadLine();
      Console.WriteLine("Enter student's email: ");
      Email = Console.ReadLine();
      Console.WriteLine("Enter student's date of birth: ");
      DateOfBirth = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Enter student's phone: ");
      Phone = Console.ReadLine();
      Console.WriteLine("Enter student's address: ");
      Address = Console.ReadLine();
      Console.WriteLine("Enter student's course: ");
      string courseName = Console.ReadLine();

      // Find the course with the given name in the list of courses
      Course course = courses.FirstOrDefault(c => c.CourseName == courseName);

      if (course == null)
      {
        // If the course doesn't exist, create a new course object and add it to the list of courses
        course = new Course(courseName, new List<Course>());
        courses.Add(course);
      }

      // Add the course to the list of courses for this student
      Courses.Add(course);
    }


    public void UpdateInformation(string studentID)
    {
      Student student = Program.students.FirstOrDefault(s => s.StudentID == studentID);
      Presentator presentator = new Presentator();
      if (student != null)
      {
        Console.WriteLine("Enter student's name: ");
        student.Name = Console.ReadLine();
        Console.WriteLine("Enter student's email: ");
        student.Email = Console.ReadLine();
        Console.WriteLine("Enter student's date of birth: ");
        student.DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter student's phone: ");
        student.Phone = Console.ReadLine();
        Console.WriteLine("Enter student's address: ");
        student.Address = Console.ReadLine();
        Console.WriteLine("Enter student's course: ");
        string courseName = Console.ReadLine();
        //Clear the list of previous courses for this
        student.Courses.Clear();
        //Add new course to the list of courses for this student
        Course course = Program.courses.FirstOrDefault(c => c.CourseName == courseName);

        if (course == null)
        {
          // If the course doesn't exist, create a new course object and add it to the list of courses
          course = new Course(courseName, new List<Course>());
          Program.courses.Add(course);
        }

        // Add the course to the list of courses for this student
        student.Courses.Add(course);
        presentator.DisplayUpdateSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStudentNotExistMessage();
      }
    }

    public void DeleteInformation(string studentID)
    {
      Presentator presentator = new Presentator();
      Student student = Program.students.FirstOrDefault(s => s.StudentID == studentID);
      if (student != null)
      {
        Program.students.Remove(student);
        student.Courses.Clear();
        presentator.DisplayDeleteSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStudentNotExistMessage();
      }
    }
  }
}