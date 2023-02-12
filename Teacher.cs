namespace CSharp_Assignment1
{
  class Teacher : Person
  {
    //Fields
    private string teacherID;
    private List<string> courses;

    //Properties
    public string TeacherID
    {
      get { return teacherID; }
      set { teacherID = value; }
    }
    public List<string> Courses
    {
      get { return courses; }
      set { courses = value; }
    }

    //Constructors
    public Teacher()
    {
    }
    public Teacher(string name, DateTime dateOfBirth, string email, string phone, string address, string teacherID, List<string> courses)
      : base(name, dateOfBirth, email, phone, address)
    {
      this.teacherID = teacherID;
      this.courses = courses;
    }

    //Overirde methods
    public override void DisplayInformation()
    {
      Console.WriteLine("=========TEACHER INFORMATION=========");
      Console.WriteLine(" |Name: " + Name);
      Console.WriteLine(" |Email: " + Email);
      Console.WriteLine(" |Date of Birth: " + DateOfBirth.ToString("dd/MM/yyyy"));
      Console.WriteLine(" |Teacher ID: " + TeacherID);
      Console.WriteLine(" |Courses: " + string.Join(", ", Courses));
      Console.WriteLine("=====================================");
    }

    //Method
    public void AssignCourse(string course)
    {
      this.courses.Add(course);
    }
  }
}