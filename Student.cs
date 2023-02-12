namespace CSharp_Assignment1
{
  class Student : Person
  {
    //Fields
    private string studentID;
    private List<string> courses;

    //Properties
    public string StudentID
    {
      get { return studentID; }
      set { studentID = value; }
    }
    public List<string> Courses
    {
      get { return courses; }
      set { courses = value; }
    }

    //Constructors
    public Student()
    {
    }
    public Student(string name, DateTime dateOfBirth, string email, string phone, string address, string studentID, List<string> courses)
      : base(name, dateOfBirth, email, phone, address)
    {
      this.studentID = studentID;
      this.courses = courses;
    }

    //Overirde methods 
    public override void DisplayInformation()
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
    public void EnrollInCourse(string course)
    {
      this.courses.Add(course);
    }
  }
}