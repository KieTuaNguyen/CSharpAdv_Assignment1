namespace CSharp_Assignment1
{
  interface IPresentator
  {
    void DisplayMenu();

    void DisplaySuccessfulMessage();

    void DisplayUpdateSuccessfulMessage();

    void DisplayDeleteSuccessfulMessage();

    void DisplayStudentNotExistMessage();

    void DisplayCourseNotExistMessage();

    void Exit();
  }
}