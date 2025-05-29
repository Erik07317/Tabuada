Console.Write("Escreva um número para ser exibida a tabuada: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine($"Tabuada do {numero}:");
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
Console.WriteLine("Tabuada concluída.");
