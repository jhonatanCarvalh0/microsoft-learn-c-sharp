// Project 01
class Unit10
{
  public static void Execute()
  {
    string? result;
    int number = 0;
    bool validNumber = false;
    Console.WriteLine("Enter an integer value between 5 and 10");
    do
    {
      result = Console.ReadLine();
      validNumber = int.TryParse(result, out number);
      if (validNumber == false)
      {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
      }

      if (validNumber && !(number >= 5 && number <= 10))
      {
        Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
      }

    } while (validNumber == false || !(number >= 5 && number <= 10));

    Console.WriteLine($"Your input value ({number}) has been accepted.");
  }
}