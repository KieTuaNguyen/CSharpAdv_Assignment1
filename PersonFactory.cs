namespace CSharp_Assignment1
{
  class PersonFactory
  {
    public static IPerson CreatePerson(string type)
    {
      if (type.ToLower() == "teacher")
      {
        return new Teacher();
      }
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