using System;

class Unit5
{
  public static void Execute(){
    Console.WriteLine("Arrays! Get started!");

    // Initialize an array of 3 strings:
    string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

    // Print out the first, second, and third values
    Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
    Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
    Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

    fraudulentOrderIDs[0] = "F000";

    Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

    Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
  }
}