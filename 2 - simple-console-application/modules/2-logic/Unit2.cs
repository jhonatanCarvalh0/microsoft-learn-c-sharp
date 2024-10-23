using System;

public class Unit2

{
  public static void Execute()
  {
    Random dice = new();
    int roll1 = dice.Next(1,7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int bonus = 0;

    Console.WriteLine("Rolling...");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine($"Roll 1 -> {roll1}");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine($"Roll 2 -> {roll2}");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine($"Roll 3 -> {roll3}");
    System.Threading.Thread.Sleep(2000);
    if (roll1 == roll2 && roll2 == roll3){
      Console.WriteLine("You rolled triplets! +6 bonus to total!");
      bonus = 6;
    } else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3){
      Console.WriteLine("You rolled doubles! +2 bonus to total!");
      bonus = 2;
    }

    int total = roll1+roll2+roll3+bonus;
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine($"Total:{total}");
    System.Threading.Thread.Sleep(2000);
    if (total > 14)
    {
      Console.WriteLine("Congratulations! You win!");
    } else {
      Console.WriteLine("Sorry buddy! You lose, try again!");
    }
  }
}
