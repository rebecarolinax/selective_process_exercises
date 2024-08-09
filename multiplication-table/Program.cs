Console.WriteLine($"Digite um número para ver a sua tabuada: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada de {number}: ");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}


