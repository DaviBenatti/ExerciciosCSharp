namespace Repetição;

class Program
{
    static void Main(string[] args)
    {
        /*
        for -> Usado quando você sabe quantas vezes vai repetir o loop.

        while -> Usado quando você não sabe quantas vezes vai repetir, e a repetição acontece quando uma condição for verdadeira.

        do/while -> É parecido com o while, mas a diferença é que mesmo que a condição seja falsa, ele executa pelo menos uma vez: "Faz primeiro depois pergunta".

        foreach -> Usado para percorrer listas/arrays
        */

        // Exemplo FOR

        // for(int i = 1; i <= 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int soma = 0;

        // for(int i = 1; i <= 10; i++)
        // {
        //     soma += i;
        //     Console.WriteLine("Soma atual: " + soma);
        // }
        // Console.WriteLine("Soma total: " + soma);

        // Exemplo WHILE

        // int i = 1;

        // while(i <= 5)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }
        // Console.WriteLine(i);

        // Exemplo DO/WHILE

        // int numero = 0;

        // do
        // {
        //     Console.WriteLine("Digite um número maior que zero: ");
        //     numero = int.Parse(Console.ReadLine());
        // }
        // while(numero <= 0);

        // Console.WriteLine("Número válido: " + numero);

        // Menu

        // int opcao;

        // do
        // {
        //     Console.WriteLine("[1] Continuar");
        //     Console.WriteLine("[2] Sair");
        //     opcao = int.Parse(Console.ReadLine());
        // } while(opcao != 2);

        // Console.WriteLine("Programa encerrado!");

        // string[] nomes = { "Ana", "Carlos", "Maria" };

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // int[] numeros = {2, 4, 6, 8};
        // int soma = 0;

        // foreach(int numero in numeros)
        // {
        //     soma += numero;
        // }
        
        // Console.WriteLine("Soma: " + soma);

        // EXERCíCIOS

        // NÍVEL FÁCIL

        // 1) CONTAGEM CRESCENTE (FOR)

        // for(int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // 2) CONTAGEM REGRESSIVA (FOR)

        // for(int i = 10; i > 0; i--)
        // {
        //     Console.WriteLine(i);
        // }

        // 3) TABUADA SIMPLES (FOR)

        // Console.Write("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // for(int i = 1; i <= 10; i++)
        // {
        //     int resultado = numero * i;
        //     Console.WriteLine(numero + " X " + i + " = " + resultado);
        // }

        // 4) REPETIÇÃO COM WHILE

        // int i = 1;

        // while(i <= 5)
        // {
        //     Console.WriteLine(i);
        //     i += 1;
        // }

        // 5) SOMA ATÉ 5 (FOR)

        // int soma = 0;
        
        // for(int i = 1; i <= 5; i++)
        // {
        //     soma += i;
        // }
        // Console.WriteLine(soma);

        // NÍVEL MÉDIO

        // 1) SOMA DE NÚMEROS DIGITADOS(FOR)

        // int soma = 0;

        // for(int i = 1; i <= 5; i++)
        // {
        //     Console.WriteLine("Digite o " + i + "º número: ");
        //     int numero = int.Parse(Console.ReadLine());
        //     soma += numero;
        // }
        // Console.WriteLine("Soma total: " + soma);

        // 2) CONTAR PARES (FOR)

        // for(int i = 1; i <= 20; i++)
        // {
        //     if(i % 2 == 0)
        //     {
        //         Console.WriteLine(i);
        //     }    
        // }

        // 3) VALIDAÇÃO DE SENHA(WHILE)

        // string senha = "";

        // while (senha != "1234")
        // {
        //     Console.Write("Digite a senha: ");
        //     senha = Console.ReadLine();

        //     if (senha != "1234")
        //     {
        //         Console.WriteLine("Senha incorreta. Tente novamente.");
        //     }
        // }

        // Console.WriteLine("Acesso permitido!");

        // 4) MENU COM REPETIÇÃO(DO WHILE)

        int opcao;

        do
        {
            Console.WriteLine("1 -> Mostrar mensagem");
            Console.WriteLine("2 -> Sair");
            Console.Write("Selecione uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            
            if(opcao < 1 || opcao > 2)
            {
                Console.WriteLine("Digite uma opção válida!");
            }
        } while(opcao != 2);
        
        Console.WriteLine("Até a próxima!");
    }
}
