// Project 02
class Unit11
{
  public static void Execute()
  {
    Console.WriteLine("Unit11 - do-and-while\n");

    Console.WriteLine("Escolha seu nome de função: Administrador, Gerente ou Usuário");
    string? userResponse;
    bool validResponse = false;

    do
    {
      userResponse = (Console.ReadLine()??"inválido").Trim().ToLower();
      validResponse = true;
      switch (userResponse)
      {
        case "administrador":
          Console.WriteLine("Bem vindo, Administrador");
          break;
        case "gerente":
          Console.WriteLine("Bem vindo, Gerente");
          break;
        case "usuario":
          Console.WriteLine("Bem vindo, Usuário");
          break;
        default:
          Console.WriteLine("Nome de função inválido, tente novamente");
          validResponse = false;
          break;
      }

    } while (validResponse == false);

    Console.WriteLine("Função descrita aceita!\nSua nova função é: " + userResponse);
  }
}