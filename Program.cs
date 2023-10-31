Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite o valor disponível para apostas: ");
int valorApostas = int.Parse(Console.ReadLine());

if (valorApostas < 5)
{
  Console.WriteLine("O valor mínimo para apostar é 5 reais");
}
else
{
  int[] numerosLoteria = new int[60];
  Random rnd = new Random();

  for (int i = 0; i < 60; i++)
  {
    numerosLoteria[i] = i + 1;
  }

  int custoPorAposta = 5;
  int quantidadeApostas = valorApostas / custoPorAposta;

  Console.WriteLine($"{nome} com {valorApostas} você consegue fazer {quantidadeApostas}");

  for (int aposta = 1; aposta <= quantidadeApostas; aposta++)
  {
    int[] seusNumeros = new int[6];

    Console.WriteLine($"Aposta {aposta}:");

    for (int j = 0; j < 6; j++)
    {
      seusNumeros[j] = numerosLoteria[rnd.Next(1, 61)];
      Console.Write(" " + seusNumeros[j] + " ");
    }

    Console.WriteLine(); 
  }
}