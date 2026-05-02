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

        // int opcao = 0;

        // do
        // {
        //     Console.WriteLine("1 -> Mostrar mensagem");
        //     Console.WriteLine("2 -> Sair");
        //     Console.Write("Selecione uma opção: ");
        //     opcao = int.Parse(Console.ReadLine());
            
        //     if(opcao < 1 || opcao > 2)
        //     {
        //         Console.WriteLine("Digite uma opção válida!");
        //     }
        // } while(opcao != 2);
        
        // Console.WriteLine("Até a próxima!");

        // 5) MÉDIA DE VALORES (FOR)

        // double soma = 0;
        // int n = 0;

        // for(int i = 1; i <= 4; i++)
        // {
        //     Console.Write("Digite o " + i + "º número: ");
        //     double num = double.Parse(Console.ReadLine());
        //     soma += num;
        //     n += 1;
        // }

        // double media = soma / n;

        // Console.WriteLine("A média dos valores é: " + media);

        // NÍVEL DIFÍCIL

        // 1) MAIOR NÚMERO DIGITADO (FOR)

        // int maior = 0;

        // for(int i = 1; i <= 5; i++)
        // {
        //     Console.Write("Digite o " + i + "º número: ");
        //     int num = int.Parse(Console.ReadLine());

        //     if(num > maior)
        //     {
        //         maior = num;
        //     }
        // }

        // Console.WriteLine("O maior número digitado é: " + maior);

        // 2) CONTAGEM COM CONDIÇÃO(WHILE)

        // Console.Write("Digite um número que seja maior que zero: ");
        // int num = int.Parse(Console.ReadLine());
        // int contador = 0;
        
        // while(num != 0)
        // {
        //     Console.Write("Digite um número que seja maior que zero: ");
        //     num = int.Parse(Console.ReadLine());
        //     contador += 1;
        // }

        // Console.WriteLine("Total de números digitados: " + contador);

        // 3) SOMA ATÉ NÚMERO NEGATIVO(WHILE)

        // Console.Write("Digite um número positivo: ");
        // int num = int.Parse(Console.ReadLine());

        // int soma = 0;

        // while(num >= 0)
        // {
        //     soma += num;
        //     Console.Write("Digite um número positivo: ");
        //     num = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("A soma dos números positivos: " + soma);

        // 4) PERCORRENDO ARRAY(FOREACH)

        // int[] numeros = {3, 7, 2, 9, 6};

        // foreach(int numero in numeros)
        // {
        //     Console.WriteLine(numero);
        // }

        // 5) MÉDIA COM FOREACH

        // double[] notas = {7.5, 8.5, 9.5, 4.0};
        // int contador = 0;
        // double soma = 0;

        // foreach(double nota in notas)
        // {
        //     soma += nota;
        //     contador += 1;
        // }

        // double media = soma / contador;

        // Console.WriteLine("A média do aluno é: " + media);
    }
}
