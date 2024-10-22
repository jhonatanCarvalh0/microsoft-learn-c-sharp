using System;

class Modulo4{
  public static void Execute(){
    Random random = new Random();
    int daysUntilExpiration = random.Next(12);
    int discountPercentage = 0;

    if (daysUntilExpiration <=10 && daysUntilExpiration > 5)
    {
      Console.WriteLine("Your subscription will expire soon. Renew now!");
    } else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
    {
      discountPercentage=10;
      Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    } else if (daysUntilExpiration == 1)
    {
      discountPercentage=20;
      Console.WriteLine($"Your subscription will expire within a day!\nRenew now and save {discountPercentage}%");
    } else if (daysUntilExpiration <= 0)
    {
      Console.WriteLine("Your subscriptions has expired!");
    }
  }
}