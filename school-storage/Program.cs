// 5) Você vai criar um programa que armazena as notas de vários alunos em diferentes disciplinas. O programa deve calcular a média de cada aluno e determinar quais alunos têm médias acima de 7.0 (aprovados) e quais têm médias abaixo de 7.0 (reprovados). O programa deve usar foreach para iterar sobre as coleções de alunos e suas notas.

// Especificações:

// - Armazene as notas de 3 disciplinas para cada aluno.
// - Calcule a média de cada aluno.
// - Exiba a média e o status (aprovado/reprovado) de cada aluno.
// - Use foreach para iterar sobre os alunos e as disciplinas.

class Aluno
{
    public string Nome;
    public string Disciplinas;
    public List<double> Notas;

    public Aluno(string nome, string disciplinas, List<double> notas)
    {
        Nome = nome;
        Disciplinas = disciplinas;
        Notas = notas;
    }

    public double CalcularMedia()
    {
        double soma = 0;
        foreach (var nota in Notas)
        {
            soma += nota;
        }
        return soma / Notas.Count;
    }
}

class Program
{
    static void Main()
    {
        // Criação de uma lista de alunos com suas respectivas notas
        List<Aluno> alunos = new List<Aluno>
        {
            new Aluno("Ana", "Português", new List<double> { 8.5, 7.0, 6.5 }),
            new Aluno("Pedro", "Matemática", new List<double> { 6.0, 5.5, 6.0 }),
            new Aluno("Maria","Biologia", new List<double> { 9.0, 8.0, 7.5 }),
            new Aluno("João", "História", new List<double> { 5.0, 6.0, 5.5 })
        };

        // Itera sobre cada aluno e calcula a média
        foreach (var aluno in alunos)
        {
            double media = aluno.CalcularMedia();
            string status = media >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine($"{aluno.Nome} - Média: {media:F2} - Disciplina: {aluno.Disciplinas} - Status: {status}");
        }
    }
}
