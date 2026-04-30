namespace Funções;

class Program
{
    static void Main(string[] args)
    {
        // static void MostrarMensagem()
        // {
        //     Console.WriteLine("Olá! boa tarde!");
        // }

        // MostrarMensagem();

        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        // }

        // Saudacao("Davi");

        // static int Somar(int a, int b)
        // {
        //     return a + b;
        // }

        // int resultado = Somar(10, 2);
        // Console.WriteLine(resultado);

        // static void ExibirDobro(int num)
        // {
        //     Console.WriteLine(num * 2);
        // }

        // ExibirDobro(10);

        // Arrays -> Armazena vários valores do mesmo tipo em uma única variável

        // int[] numeros = new int[5];

        // Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;

        // Console.WriteLine(numeros);

        // string[] nomes = {"Penelope", "Juan", "Davi"};

        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        // string[] nomes = {"Penelope", "Juan", "Davi"};

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Função + Array

        // static double CalcularMedia(double[] notas)
        // {
        //     double soma = 0;
        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //     }
        //     return soma / notas.Length;
        // }

        // double[] notasAluno = {8.0, 7.5, 9.0, 6.5};

        // double media = CalcularMedia(notasAluno);

        // Console.WriteLine($"Média final: {media}");

        // int[] numeros = new int[5];
        // int soma = 0;

        // for(int i = 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine($"Digite o {i + 1}º número: ");
        //     numeros[i] = int.Parse(Console.ReadLine());

        //     soma += numeros[i];
        // }

        // Console.WriteLine(string.Join(", ", numeros));
        // Console.WriteLine($"A soma dos números é: {soma}");

        static string VerificarSituacao(double nota)
        {
            if(nota >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

        string[] alunos = new string[3];
        double[] notas = new double[3];
        
        for(int i = 0; i < alunos.Length; i++)
        {
            Console.Write("Digite o nome do aluno: ");
            alunos[i] = Console.ReadLine();

            Console.WriteLine("Digite a nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        for(int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        }
    }
}
