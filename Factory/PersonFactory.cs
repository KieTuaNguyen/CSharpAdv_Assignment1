namespace CSharp_Assignment1
{
    class PersonFactory
    {
        public static IPerson CreatePerson(string type)
        {
            //Create teacher object
            //type.ToLower() is used to convert the string to lowercase
            if (type.ToLower() == "student")
            {
                return new Student();
            }
            else if (type.ToLower() == "staff")
            {
                return new Staff();
            }
            else
            {
                throw new ArgumentException("Invalid person type.");
            }
        }
    }
}