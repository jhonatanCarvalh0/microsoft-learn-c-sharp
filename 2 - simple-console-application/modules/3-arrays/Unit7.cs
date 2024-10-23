using System;

class Unit7
{
  public static void Execute(){
    Console.WriteLine("Unit7 - Foreach with Array");

    string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

    foreach(string orderID in orderIDs)
    {
      if (orderID.StartsWith("B"))
      {
        Console.WriteLine(orderID);
      }
    }
  }
}