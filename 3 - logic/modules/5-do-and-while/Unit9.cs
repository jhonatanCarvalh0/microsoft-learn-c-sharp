class Unit9
{
  public static void Execute()
  {
    Random attack = new Random();
    var heroLifePoints = 10;
    var monsterLifePoints = 10;
    int attackValue = 0;

    Console.WriteLine("The Great Battle is about to begin...");
    Thread.Sleep(2000);
    Console.WriteLine("Prepare yourself!! Which one is going to prevail?\n");
    Thread.Sleep(2000);
    Console.WriteLine($"Hero: {heroLifePoints}LP VS. Monster: {monsterLifePoints}LP");
    Thread.Sleep(2000);
    Console.Write("REEEEEADY!...");
    Thread.Sleep(2000);
    Console.WriteLine("Fight!\n");

    do
    {

      if (heroLifePoints > 0)
      {
        Thread.Sleep(2000);
        attackValue = attack.Next(1, 10);
        Console.WriteLine("Hero attacks!");
        monsterLifePoints -= attackValue;
        if (monsterLifePoints <= 0)
        {
          Console.WriteLine("Hero's Special Attack: SPEAR OF JUSTICE!!!!\n");
        }
        else
        {
          Console.WriteLine($"Monster was damaged and lost {attackValue} health and now has {monsterLifePoints} health.\n");
        }
      }

      if (monsterLifePoints > 0)
      {
        Thread.Sleep(2000);
        attackValue = attack.Next(1, 10);
        Console.WriteLine("Monster attacks!");
        heroLifePoints -= attackValue;
        if (heroLifePoints <= 0)
        {
          Console.WriteLine("Monster's Special Attack: HELL'S FIRE AXE!!!!\n");
        }
        else
        {
          Console.WriteLine($"Hero was damaged and lost {attackValue} health and now has {heroLifePoints} health.\n");
        }
      }

      if (heroLifePoints <= 0)
      {
        Thread.Sleep(2000);
        Console.WriteLine("WHATAA HEEEELL!!! WHAT A CRAZY BATTLE!!");
        Thread.Sleep(2000);
        Console.WriteLine("WAIT!!!   The Special Attack defeated Hero!! He loses!! It's settled!!");
        Thread.Sleep(2000);
        Console.WriteLine("Monster wins!!");
      }
      else if (monsterLifePoints <= 0)
      {
        Thread.Sleep(2000);
        Console.WriteLine("WHATAA HEEEELL!!! WHAT A CRAZY BATTLE!!");
        Thread.Sleep(2000);
        Console.WriteLine("WAIT!!!   The Special Attack defeated Monster!! He loses!! It's settled!!");
        Thread.Sleep(2000);
        Console.WriteLine("Hero wins!");
      }

    } while (heroLifePoints > 0 && monsterLifePoints > 0);
    Thread.Sleep(2000);
    Console.WriteLine("\nGame Over!!! Thanks Guys, i see you all in the next battle!");
  }
}