// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 1; i++)
{
  Console.WriteLine("Running Program!...");
  Thread.Sleep(2000);
  Unit3.Execute();
  PrintSeparator(i);
}
void PrintSeparator(int i)
{
  if (i >= 1)
  {
    Console.WriteLine("######################");
  }
}