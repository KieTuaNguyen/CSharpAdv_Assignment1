namespace CSharp_Assignment1
{
  class Program
  {
    static void Main(string[] args)
    {
      Presentator presentator = new Presentator();

      presentator.DisplayMenu();
      Console.WriteLine("Enter your choice: ");

      StudentManager studentManager = new StudentManager();

      int choice = 0;
      do
      {
        try
        {
          choice = int.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {
          Console.WriteLine("Invalid input. Please enter a number.");
          continue;
        }
        switch (choice)
        {
          case 1:
            //Add new course
            studentManager.AddNewCourse();
            break;
          case 2:
            //Add new student's
            studentManager.AddNewStudent();
            break;
          case 3:
            //Display specific course information
            studentManager.DisplaySpecificCourseInformation();
            break;
          case 4:
            //Display specific student information
            studentManager.DisplaySpecificStudentInformation();
            break;
          case 5:
            //Display all courses
            studentManager.DisplayAllCourses();
            break;
          case 6:
            //Display all students
            studentManager.DisplayAllStudents();
            break;
          case 7:
            //Update student's information
            studentManager.UpdateStudentInformation();
            break;
          case 8:
            //Delete student's information
            studentManager.DeleteStudentInformation();
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