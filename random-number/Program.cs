//4) crie um programa que gere um número entre 1 e 100. O usuário deve tentar adivinhar esse número. O programa deve continuar pedindo um palpite até que o usuário acerte o número. Ao final, mostre quantas tentativas foram necessárias

// instancia o método random, responsável por gerar números aleatórios
Random random = new Random();


// defini as variáveis de número aleatório, número de palpites e número de tentativas
int numeroAleatorio = random.Next(1, 1);
int palpite;
int tentativas = 0; // inicia-se 0

// exibe no console
Console.WriteLine($"Adivinhe um número de 1 a 100.");

do
{
    // renderiza antes da verificação da condição
    Console.WriteLine($"Digite seu palpite: ");

    // recebe o palpite e guarda na variável
    palpite = int.Parse(Console.ReadLine());

    // itera o valor de tentativas a cada loop
    tentativas++;

    //se palpite for menor que o número aleatório, exibe 
    if (palpite < numeroAleatorio)
    {
        Console.WriteLine($"O número é maior. Tente novamente!");
    }

    // se palpite for maior que número aleatório, exibe
    else if (palpite > numeroAleatorio)
    {
        Console.WriteLine($"O número é menor. Tente novamente!");
    }

    // se palpite for igual a palpite, exibe
    else
    {
        Console.WriteLine($"Parabéns. Você acertou o número {numeroAleatorio}");
    }

    // condição que encerra o loop
} while (palpite != numeroAleatorio);

// finaliza com o número de tentativas
Console.WriteLine($"Número de tentativas: {tentativas}");




//

