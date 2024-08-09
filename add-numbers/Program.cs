int soma = 0;

int numero = 1;

while (numero <= 100)
{
    if (numero % 2 == 0)
    {
        soma += numero;
    }
    numero++;
}

Console.WriteLine($"A soma dos números pares de 1 a 100 é igual a {soma}");
