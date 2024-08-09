

Console.WriteLine($"Digite a nota do aluno:");
int nota = int.Parse(Console.ReadLine()!);

if (nota == 0)
{
    Console.WriteLine($"Aluno Reprovado");
}
else if (nota <= 5)
{
    Console.WriteLine($"Aluno de recuperação");
}
else if (nota < 10)
{
    Console.WriteLine($"Nota inválida! ");
}
else
{
    Console.WriteLine($"Aluno aprovado");
}