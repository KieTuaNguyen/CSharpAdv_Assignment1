namespace CSharp_Assignment1
{
  class Presentator : IPresentator
  {
    //Method
    public void DisplayMenu()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("|                                    v14.1.0|");
      Console.WriteLine("=========GREENWICH MANAGEMENT SYSTEM=========");
      Console.WriteLine("1 | Add new course                          |");
      Console.WriteLine("2 | Add new student's information           |");
      Console.WriteLine("3 | Display specific course information     |");
      Console.WriteLine("4 | Display specific student information    |");
      Console.WriteLine("5 | Show all courses in the system          |");
      Console.WriteLine("6 | Show all students in the system         |");
      Console.WriteLine("7 | Update specific student by their ID     |");
      Console.WriteLine("8 | Delete specific student by their ID     |");
      Console.WriteLine("9 | Exit the program                        |");
      Console.WriteLine("=============================================");
      Console.WriteLine("        Please choose your option:           ");
    }

    public void DisplaySuccessfulMessage()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("   The information is added successfully");
      Console.WriteLine("=============================================");
    }

    public void DisplayUpdateSuccessfulMessage()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("  The information is updated successfully");
      Console.WriteLine("=============================================");
    }

    public void DisplayDeleteSuccessfulMessage()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("  The information is deleted successfully");
      Console.WriteLine("=============================================");
    }

    public void DisplayStudentNotExistMessage()
    {
      Console.WriteLine("==============STUDENT INFORMATION============");
      Console.WriteLine("          The student is not existed      ");
      Console.WriteLine("=============================================");
    }

    public void DisplayCourseNotExistMessage()
    {
      Console.WriteLine("==============COURSE INFORMATION=============");
      Console.WriteLine("          The course is not existed      ");
      Console.WriteLine("=============================================");
    }

    public void Exit()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("      Thank you for using our system");
      Console.WriteLine("=============================================");
      Console.WriteLine("|         School Management System          |");
      Console.WriteLine("|==============by KietGDD210002=============|");
    }
  }
}