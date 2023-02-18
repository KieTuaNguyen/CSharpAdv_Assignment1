namespace CSharp_Assignment1
{
  class Student : IPerson
  {
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string StudentID { get; set; }
    public List<string> Courses { get; set; }

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
    public void EnrollInCourse(string course)
    {
      Courses.Add(course);
    }

    public void InputInformation()
    {
      Console.WriteLine("Enter student's ID: ");
      StudentID = Console.ReadLine();
      Console.WriteLine("Enter student's name: ");
      Name = Console.ReadLine();
      Console.WriteLine("Enter student's email: ");
      Email = Console.ReadLine();
      Console.WriteLine("Enter student's courses: ");
      Courses = Console.ReadLine().Split(',').ToList();
      Console.WriteLine("Enter student's date of birth: ");
      DateOfBirth = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Enter student's phone: ");
      Phone = Console.ReadLine();
      Console.WriteLine("Enter student's address: ");
      Address = Console.ReadLine();
      Console.WriteLine(" -------------------------------------");
      Console.WriteLine(" The information is added successfully");
      Console.WriteLine(" -------------------------------------");
    }

    public void DeleteInformation()
    {
    }

    public void UpdateInformaton()
    {
    }
  }
}