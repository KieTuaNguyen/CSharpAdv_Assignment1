namespace CSharp_Assignment1
{
  class CourseFactory
  {
    public static ICourse CreateCourse(string type)
    {
      //Create teacher object
      //type.ToLower() is used to convert the string to lowercase
      if (type.ToLower() == "course")
      {
        return new Course();
      }
      else
      {
        throw new ArgumentException("Invalid course.");
      }
    }
  }
}