using System;

class Unit6
{
  public static void Execute(){
    Console.WriteLine("Unit6 - Foreach with Array");
    int[] inventory = [200, 450, 700, 175, 250];
    int sum = 0;
    int bin = 0;

    foreach(int item in inventory){
      sum += item;
      bin++;
      Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
    }

    Console.WriteLine($"We have {sum} items in inventory.");
  }

}