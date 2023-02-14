namespace CSharp_Assignment1
{
  interface IVietnameseTarget
  {
    //Define target interface
    void Send(string message);
  }

  class TranslatorAdapter : IVietnameseTarget
  {
    //Define target
    private EnglishMessage englishMessage;

    //Constructor
    public TranslatorAdapter(EnglishMessage englishMessage)
    {
      this.englishMessage = englishMessage;
    }

    //Send message
    public void Send(string message)
    {
      System.Console.WriteLine("Reading message ...");
      System.Console.WriteLine(message);
      string vietnameseMessage = Translate(message);
      System.Console.WriteLine("Sending message ...");
      englishMessage.Receive(vietnameseMessage);
    }

    //Translate Vietnamese to English 
    private string Translate(string vietnameseMessage)
    {
      System.Console.WriteLine("Translating message ...");
      return "Hello";
    }
  }

  class EnglishMessage
  {
    public void Receive(string message)
    {
      System.Console.WriteLine("Received message: " + message);
    }
  }

  // class VietnameseCustomer
  // {
  //   static void Main(string[] args)
  //   {
  //     //Create English Message
  //     EnglishMessage englishMessage = new EnglishMessage();
  //     //Create new Vietnamese and define target is English Message
  //     IVietnameseTarget vietnamese = new TranslatorAdapter(englishMessage);
  //     //Send message
  //     vietnamese.Send("Xin chào");
  //   }
  // }
}