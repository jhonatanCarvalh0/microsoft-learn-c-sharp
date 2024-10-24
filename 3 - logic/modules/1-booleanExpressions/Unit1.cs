class Unit1
{
  public static void Execute(){
    Console.WriteLine("Unit1 - booleanExpressions\n");
    Console.WriteLine("a"=="a");
    Console.WriteLine("a" == "A");
    Console.WriteLine(1 == 2);
    string myValue = "a";
    Console.WriteLine(myValue == "a");

    string value1 = " a";
    string value2 = "A ";
    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

    Console.WriteLine("a" != "a");
    Console.WriteLine("a" != "A");
    Console.WriteLine(1 != 2);

    string myValue1 = "a";
    Console.WriteLine(myValue1 != "a");

    Console.WriteLine(1 > 2);
    Console.WriteLine(1 < 2);
    Console.WriteLine(1 >= 1);
    Console.WriteLine(1 <= 1);

    string pangram = "The quick brown fox jumps over the lazy dog.";
    Console.WriteLine(pangram.Contains("fox"));
    Console.WriteLine(pangram.Contains("cow"));

    // These two lines of code will create the same output

    Console.WriteLine(pangram.Contains("fox") == false);
    Console.WriteLine(!pangram.Contains("fox"));
  }
}