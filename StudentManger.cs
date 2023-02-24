namespace CSharp_Assignment1
{
  class StudentManager
  {
    public static List<Student> students { get; internal set; }
    public static List<Course> courses { get; internal set; }
    public static Presentator presentator;
    public static Course course;
    public static Student student;


    public Course CreateCourse()
    {
      return (Course)CourseFactory.CreateCourse("course");
    }

    public Student CreateStudent()
    {
      return (Student)PersonFactory.CreatePerson("student");
    }

    public void AddNewCourse()
    {
      course = CreateCourse();
      course.InputInformation();
      courses.Add(course);
      presentator.DisplaySuccessfulMessage();
      presentator.DisplayMenu();
    }

    public void AddNewStudent()
    {
      student = CreateStudent();
      student.InputInformation(courses);
      students.Add(student);
      presentator.DisplaySuccessfulMessage();
      presentator.DisplayMenu();
    }

    public void DisplaySpecificCourseInformation()
    {
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

    }

    public void DisplaySpecificStudentInformation()
    {
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
    }

    public void DisplayAllCourses()
    {
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
    }

    public void DisplayAllStudents()
    {
      foreach (Student s in students)
      {
        s.DisplayInformation();
      }
      presentator.DisplayMenu();
    }

    public void UpdateStudentInformation()
    {
      student = new Student();
      Console.WriteLine("Enter student's ID: ");
      string studentIDUpdate = Console.ReadLine();
      student.UpdateInformation(studentIDUpdate);
      presentator.DisplayMenu();
    }

    internal void DeleteStudentInformation()
    {
      student = new Student();
      Console.WriteLine("Enter student's ID: ");
      string studentIDDelete = Console.ReadLine();
      student.DeleteInformation(studentIDDelete);
      presentator.DisplayMenu();
    }

    public StudentManager()
    {
      //Create list of students and courses
      students = new List<Student>();
      courses = new List<Course>();

      course = (Course)CourseFactory.CreateCourse("course");
      student = (Student)PersonFactory.CreatePerson("student");

      presentator = new Presentator();
    }
  }
}