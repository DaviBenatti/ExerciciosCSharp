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

        // static string VerificarSituacao(double nota)
        // {
        //     if(nota >= 7)
        //     {
        //         return "Aprovado";
        //     }
        //     else
        //     {
        //         return "Reprovado";
        //     }
        // }

        // string[] alunos = new string[3];
        // double[] notas = new double[3];
        
        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.Write("Digite o nome do aluno: ");
        //     alunos[i] = Console.ReadLine();

        //     Console.WriteLine("Digite a nota: ");
        //     notas[i] = double.Parse(Console.ReadLine());
        // }

        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        // }

        // Random (Gerar números aleatórios)
        // Random random = new Random(); // Cria o gerador de números automáticos
        // int numero = random.Next(1, 101); // Gera números entre 1 e 100
        // int numero = random.Next(101); // Gera os números começando com 0

        // Console.WriteLine(numero);

        // Funções para String

        // Tamanho da String
        // string texto = "CSharp";
        // int tamanho = texto.Length;

        // Console.WriteLine(tamanho);

        // Trocando um elemento por outro
        // string frase = "Olá mundo!";
        // frase = frase.Replace("mundo", "C#");

        // Console.WriteLine(frase);
        
        // Autenticar existência de elemento na string
        // string frase = "Estou aprendendo C#";

        // if(frase.Contains("C#"))
        // {
        //     Console.WriteLine("A frase contém 'C#'");
        // }

        // bool existe = frase.Contains("C#");
        // Console.WriteLine(existe);

        // Ordenar valores em uma array
        // int[] numeros = {1, 2, 4, 12, 8};
        // Array.Sort(numeros); // Ordenando valores
        // Console.WriteLine(string.Join(", ", numeros));

        // // Inverter valores
        // Array.Reverse(numeros);
        // Console.WriteLine(string.Join(", ", numeros));

        // Simular adicionar valores em array

        // string[] nomes = {"Ana", "Bruno", "Carlos"};

        // string novoNome = "Pedro";

        // string novoArray = new string[nomes.Length + 1];

        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     novoArray[i] = nomes[i];
        // }

        // novoArray[novoArray.Length - 1] = novoNome;
        // nomes = novoArray;

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Adicionando elementos com List

        // List<string> nomes = new List<string>();

        // // Adicionando nomes na lista (Add)
        // nomes.Add("Ana");
        // nomes.Add("Bruno");
        // nomes.Add("Carlos");
        // nomes.Add("Pedro");

        // // Removendo nomes na lista (Remove)

        // nomes.Remove("Bruno");

        // // foreach(string nome in nomes)
        // // {
        // //     Console.WriteLine(nome);
        // // }

        // // // Acessar pela posição(Indice)
        // // Console.WriteLine(nomes[0]);

        // //Tamanho da lista
        // // Console.WriteLine(nomes.Count);

        // // Realizando busca dentro da lista

        // // Console.WriteLine("Digite o nome da busca: ");
        // // string nomeDigitado = Console.ReadLine();

        // // if(nomes.Contains(nomeDigitado))
        // // {
        // //     Console.WriteLine("Nome encontrado!");
        // // }

        // // Inserindo nome em posição específica
        // nomes.Insert(2, "Paula");

        // // Removendo nome na posição
        // nomes.RemoveAt(3);

        // // Limpando a lista
        // nomes.Clear();

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Sisteminha: Removendo item digitado

        // List<string> produtos = new List<string>();

        // produtos.Add("Mouse");
        // produtos.Add("Teclado");
        // produtos.Add("Monitor");

        // Console.Write("Digite o produto para remover: ");
        // string remover = Console.ReadLine();

        // if(produtos.Contains(remover))
        // {
        //     // Vai remover o produto
        //     produtos.Remove(remover);

        //     foreach(string produto in produtos)
        //     {
        //         Console.WriteLine(produto);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Produto digitado não existe na lista.");
        // }

        // MENU COM LIST

        int opcao = 0;
        List<string> tarefas = new List<string>();

        do
        {
            Console.WriteLine("BEM-VINDO A LISTA DE TAREFAS!");
            Console.WriteLine("[1] - Adicionar tarefa");
            Console.WriteLine("[2] - Listar tarefas");
            Console.WriteLine("[3] - Remover tarefa");
            Console.WriteLine("[0] - Sair");
            Console.Write("SELECIONE UMA OPÇÃO: ");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Console.Write("Digite a tarefa que você deseja adicionar: ");
                    string novaTarefa = Console.ReadLine();
                    tarefas.Add(novaTarefa);
                    break;
                
                case 2:
                    if(tarefas.Count > 0)
                    {
                        foreach(string tarefa in tarefas)
                        {
                            Console.WriteLine(tarefa);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lista vazia.");
                    }
                    break;

                case 3:
                    Console.Write("Digite o produto para remover: ");
                    string remover = Console.ReadLine();

                    if(tarefas.Contains(remover))
                    {
                        // Vai remover o produto
                        tarefas.Remove(remover);
                        Console.WriteLine("Tarefa removida: " + remover);
                    }
                    else
                    {
                        Console.WriteLine("Tarefa digitada não existe na lista.");
                    }
                    break;
            }
        } while(opcao != 0);
    }
}
