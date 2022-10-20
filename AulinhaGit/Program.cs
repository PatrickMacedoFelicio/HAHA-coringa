// See https://aka.ms/new-console-template for more information
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-");
Console.WriteLine("[1] - Saudação.");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-");

Console.Write("Escolha uma opção: ");
int opc = Convert.ToInt32(Console.ReadLine());

if (opc == 1)
{
    Console.Clear();
    Console.WriteLine("Qual é o seu nome?");
    string nome = Console.ReadLine();

    Console.WriteLine("\nOlá, " + nome + "!");
}