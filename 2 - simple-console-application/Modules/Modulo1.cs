using System;

public class Modulo1
{
  public static void Execute()
  {
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, CSharper!\n");
    // Need C# toolkit for devs Extension on VSCode

    Random dice = new();

    int roll1 = dice.Next();
    int roll2 = dice.Next(101);
    int roll3 = dice.Next(50, 101);

    Console.WriteLine(@$"
  First Roll: {roll1}
  Second Roll: {roll2}
  Third Roll: {roll3}
");

    // Desafio - search for the class Math method which returns the larger of two numbers

    int firstValue = 500;
    int secondValue = 600;
    int largerValue = Math.Max(firstValue, secondValue); ;

    Console.WriteLine(largerValue);
  }
}
