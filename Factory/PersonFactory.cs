namespace CSharp_Assignment1
{
  class PersonFactory
  {
    public static IPerson CreatePerson(string type)
    {
      //Create teacher object
      //type.ToLower() is used to convert the string to lowercase
      if (type.ToLower() == "teacher")
      {
        return new Teacher();
      }
      //Create student object
      else if (type.ToLower() == "student")
      {
        return new Student();
      }
      else
      {
        throw new ArgumentException("Invalid person type.");
      }
    }
  }
}