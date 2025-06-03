int numero;

Console.WriteLine("-- Tabuada.exe --");

Console.WriteLine("Digite o número que você deseja saber a tabuada: ");
while (!int.TryParse(Console.ReadLine()!, out numero))
{
    Console.WriteLine("Digite um número válido");
}

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine("Digite uma tecla qualquer para finalizar o programa!");
Console.ReadKey();