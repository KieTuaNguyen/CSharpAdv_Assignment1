namespace CSharp_Assignment1
{
  class Teacher : IPerson
  {
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string TeacherID { get; set; }
    public List<string> Courses { get; set; }

    //Overirde methods
    public void DisplayInformation()
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
      Courses.Add(course);
    }

    public void InputInformation()
    {
      Console.WriteLine("Enter teacher's ID: ");
      TeacherID = Console.ReadLine();
      Console.WriteLine("Enter teacher's name: ");
      Name = Console.ReadLine();
      Console.WriteLine("Enter teacher's email: ");
      Email = Console.ReadLine();
      Console.WriteLine("Enter teacher's courses: ");
      Courses = Console.ReadLine().Split(',').ToList();
      Console.WriteLine("Enter teacher's date of birth: ");
      DateOfBirth = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Enter teacher's phone: ");
      Phone = Console.ReadLine();
      Console.WriteLine("Enter teacher's address: ");
      Address = Console.ReadLine();
      Console.WriteLine(" -------------------------------------");
      Console.WriteLine(" The information is added successfully");
      Console.WriteLine(" -------------------------------------");

    }

    public void UpdateInformaton()
    {
    }

    public void DeleteInformation()
    {
    }
  }
}