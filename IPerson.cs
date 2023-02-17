namespace CSharp_Assignment1
{
  //Applying Factory Design Pattern
  interface IPerson
  {
    string Name { get; set; }
    DateTime DateOfBirth { get; set; }
    string Email { get; set; }
    string Phone { get; set; }
    string Address { get; set; }

    void DisplayInformation();
    void InputInformation();
    void UpdateInformaton();
    void DeleteInformation();
  }
}