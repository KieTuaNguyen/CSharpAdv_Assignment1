namespace CSharp_Assignment1
{
  class Staff : IPerson
  {
    public Staff()
    {
    }

    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string StaffID { get; set; }

    public void InputInformation()
    {
      bool uniqueID = false;
      while (!uniqueID)
      {
        Console.WriteLine("Enter staff's ID: ");
        StaffID = Console.ReadLine();

        // Check if the staff ID already exists
        bool staffIDExists = StudentManager.staffs.Any(s => s.StaffID == StaffID);
        if (!staffIDExists)
        {
          uniqueID = true;
        }
        else
        {
          Console.WriteLine("Staff ID already exists. Please re-enter.");
        }
      }
      Console.WriteLine("Enter staff's name: ");
      Name = Console.ReadLine();
      Console.WriteLine("Enter staff's email: ");
      Email = Console.ReadLine();
      bool validDate = false;
      while (!validDate)
      {
        Console.WriteLine("Enter staff's date of birth: ");
        try
        {
          DateOfBirth = DateTime.Parse(Console.ReadLine());
          validDate = true;
        }
        catch (System.FormatException)
        {
          Console.WriteLine("Invalid date. Please re-enter.");
        }
      }
      Console.WriteLine("Enter staff's phone: ");
      Phone = Console.ReadLine();
      Console.WriteLine("Enter staff's address: ");
      Address = Console.ReadLine();
    }

    public void DisplayInformation()
    {
      Console.WriteLine("==============STAFF INFORMATION==============");
      Console.WriteLine(" |Staff ID: " + StaffID);
      Console.WriteLine(" |Name: " + Name);
      Console.WriteLine(" |Date of birth: " + DateOfBirth.ToString("dd/MM/yyyy"));
      Console.WriteLine(" |Email: " + Email);
      Console.WriteLine(" |Phone: " + Phone);
      Console.WriteLine(" |Address: " + Address);
      Console.WriteLine("=============================================");
    }

    public void UpdateInformation(string staffID)
    {
      Staff staff = StudentManager.staffs.FirstOrDefault(s => s.StaffID == staffID);
      Presentator presentator = new Presentator();
      if (staff != null)
      {
        Console.WriteLine("Enter staff's name: ");
        staff.Name = Console.ReadLine();
        Console.WriteLine("Enter staff's email: ");
        staff.Email = Console.ReadLine();
        Console.WriteLine("Enter staff's date of birth: ");
        staff.DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter staff's phone: ");
        staff.Phone = Console.ReadLine();
        Console.WriteLine("Enter staff's address: ");
        staff.Address = Console.ReadLine();
        presentator.DisplayUpdateSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStaffNotExistMessage();
      }
    }

    public void DeleteInformation(string staffID)
    {
      Staff staff = StudentManager.staffs.FirstOrDefault(s => s.StaffID == staffID);
      Presentator presentator = new Presentator();
      if (staff != null)
      {
        StudentManager.staffs.Remove(staff);
        presentator.DisplayDeleteSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStaffNotExistMessage();
      }
    }

    public void InputInformation(List<Course> courses)
    {
      throw new NotImplementedException();
    }
  }
}