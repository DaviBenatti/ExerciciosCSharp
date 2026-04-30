namespace ExerciciosCSharpCondicionais;

class Program
{
    static void Main(string[] args)
    {
        // EXERCÍCIOS CONDICIONAIS

        // NÍVEL FÁCIL

        // 1) TEMPERATURA

        // Console.Write("Digite a temperatura em graus célsius: ");
        // float temperatura = float.Parse(Console.ReadLine());

        // if(temperatura <= 15)
        // {
        //     Console.WriteLine("Clima frio!");
        // }
        // else if(temperatura > 15 && temperatura <= 27)
        // {
        //     Console.WriteLine("Clima agradável!");
        // }
        // else
        // {
        //     Console.WriteLine("Clima quente!");
        // }

        // 2) NÚMERO VÁLIDO

        // Console.Write("Digite um número maior que 100: ");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero > 100)
        // {
        //     Console.WriteLine(numero + " é maior que 100!");
        // }
        // else
        // {
        //     Console.WriteLine(numero + " é menor que 100!");
        // }

        // 3) SENHA SIMPLES

        // Console.Write("Digite a senha: ");
        // string senha = Console.ReadLine();

        // if(senha == "123")
        // {
        //     Console.WriteLine("Acesso liberado!");
        // }
        // else
        // {
        //     Console.WriteLine("Senha incorreta!");
        // }

        // 4) NÚMERO NEGATIVO

        // Console.Write("Digite um número positivo: ");
        // int num = int.Parse(Console.ReadLine());

        // if(num < 0)
        // {
        //     Console.WriteLine("Número inválido");
        // }
        // else
        // {
        //     Console.WriteLine("Número positivo!");
        // }

        // 5) TERNÁRIO - POSITIVO OU NEGATIVO

        // Console.WriteLine("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // string cadastro = idade >= 16 ? "Cadastro permitido" : "Cadastro não permitido";

        // Console.WriteLine(cadastro);

        // 6) TURNO DO DIA (SWITCH)

        // Console.WriteLine("Selecione o turno (1 para manhã, 2 para tarde ou 3 para noite): ");
        // int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        // {
        //     case 1:
        //         Console.WriteLine("Manhã");
        //         break;
        //     case 2:
        //         Console.WriteLine("Tarde");
        //         break;
        //     case 3:
        //         Console.WriteLine("Noite");
        //         break;
        //     default:
        //         Console.WriteLine("Inválido!");
        //         break;
        // }

        // 7) MENU SIMPLES (SWITCH)

        // Console.WriteLine("[1] Novo Jogo");
        // Console.WriteLine("[2] Carregar Jogo");
        // Console.WriteLine("[3] Sair");
        // Console.Write("Selecione uma opção: ");
        // int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        // {
        //     case 1:
        //         Console.WriteLine("Novo Jogo");
        //         break;
        //     case 2:
        //         Console.WriteLine("Carregar Jogo");
        //         break;
        //     case 3:
        //         Console.WriteLine("Sair");
        //         break;
        //     default:
        //         Console.WriteLine("Opção inválida!");
        //         break;
        // }

        // NÍVEL MÉDIO

        // 1) CLASSIFICAÇÃO DE IDADE

        // Console.WriteLine("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade > 0 && idade <= 12)
        // {
        //     Console.WriteLine("Criança");
        // }
        // else if(idade > 12 && idade < 18)
        // {
        //     Console.WriteLine("Adolescente");
        // }
        // else if(idade > 17)
        // {
        //     Console.WriteLine("Adulto");
        // }

        // 2) MAIOR ENTRE DOIS (TERNÁRIO)

        // Console.Write("Digite o primeiro número: ");
        // int num1 = int.Parse(Console.ReadLine());

        // Console.Write("Digite o segundo número: ");
        // int num2 = int.Parse(Console.ReadLine());

        // int maior = num1 > num2 ? num1 : num2;

        // Console.WriteLine("O maior número é: " + maior);

        // 3) ACESSO COM DUAS CONDIÇÕES

        // Console.WriteLine("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // Console.WriteLine("Possui ingresso? (true/false): ");
        // bool ingresso = bool.Parse(Console.ReadLine());

        // if(idade >= 18)
        // {
        //     if(ingresso)
        //     {
        //         Console.WriteLine("Acesso liberado!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Acesso negado! Compre o ingresso para entrar!");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado! Você é menor de idade!");
        // }

        // 4) NÚMERO DENTRO DE FAIXA INVÁLIDA

        // Console.WriteLine("Digite um número entre 0 e 10: ");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero < 0 || numero > 10)
        // {
        //     Console.WriteLine("Valor inválido!");
        // }

        // 5) DESCONTO POR IDADE

        // Console.WriteLine("Para verificar se há desconto, digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade < 18)
        // {
        //     Console.WriteLine("Sem desconto!");
        // }
        // else if(idade >= 18 && idade < 60)
        // {
        //     Console.WriteLine("10% de desconto!");
        // }
        // else
        // {
        //     Console.WriteLine("20% de desconto!");
        // }

        // 6) DESCONTO COM TERNÁRIO

        // Console.WriteLine("Digite o valor da compra: ");
        // decimal compra = decimal.Parse(Console.ReadLine());

        // string desconto = compra >= 200 ? "15% de desconto!" : "5% de desconto!";

        // Console.WriteLine(desconto);

        // 7) CALCULADORA COM SWITCH

        // Console.WriteLine("Digite o primeiro número: ");
        // int num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // int num2 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite a operação que você deseja realizar(+, -, *, /): ");
        // string operacao = Console.ReadLine();
        
        // switch(operacao)
        // {
        //     case "+":
        //         Console.WriteLine(num1 + num2);
        //         break;

        //     case "-":
        //         Console.WriteLine(num1 - num2);
        //         break;

        //     case "*":
        //         Console.WriteLine(num1 * num2);
        //         break;

        //     case "/":
        //         Console.WriteLine(num1 / num2);
        //         break;

        //     default:
        //         Console.WriteLine("Operação inválida!");
        //         break;
        // }

        // 8) DIA ÚTIL OU FIM DE SEMANA(SWITCH)

        // Console.WriteLine("Digite um número entre 1 e 7 (Dias da Semana): ");
        // int dia = int.Parse(Console.ReadLine());

        // switch(dia)
        // {
        //     case 1:
        //         Console.WriteLine("Fim de semana!");
        //         break;

        //     case 2:
        //         Console.WriteLine("Dia útil!");
        //         break;

        //     case 3:
        //         Console.WriteLine("Dia útil!");
        //         break;

        //     case 4:
        //         Console.WriteLine("Dia útil!");
        //         break;

        //     case 5:
        //         Console.WriteLine("Dia útil!");
        //         break;

        //     case 6:
        //         Console.WriteLine("Dia útil!");
        //         break;

        //     case 7:
        //         Console.WriteLine("Fim de semana!");
        //         break;

        //     default:
        //         Console.WriteLine("Dia inválido!");
        //         break;
        // }

        // 9) PLANO DE INTERNET(SWITCH)

        // Console.WriteLine("Qual é o seu plano de internet? (Básico/Intermediário/Premium)");
        // string plano = Console.ReadLine();

        // switch(plano)
        // {
        //     case "Básico":
        //         Console.WriteLine("10MB");
        //         break;

        //     case "Intermediário":
        //         Console.WriteLine("50MB");
        //         break;

        //     case "Premium":
        //         Console.WriteLine("100MB");
        //         break;

        //     default:
        //         Console.WriteLine("Plano inválido!");
        //         break;
        // }

        // NÍVEL DIFÍCIL

        // 1) SISTEMA DE NOTAS COMPLETO

        // Console.WriteLine("Digite a nota: ");
        // int nota = int.Parse(Console.ReadLine());

        // if(nota >= 7 && nota <= 10)
        // {
        //     Console.WriteLine("Aprovado!");
        // }
        // else if(nota < 7 && nota >= 5)
        // {
        //     Console.WriteLine("Recuperação!");
        // }
        // else if(nota < 5 && nota >= 0)
        // {
        //     Console.WriteLine("Reprovado!");
        // }
        // else
        // {
        //     Console.WriteLine("Nota inválida!");
        // }

        // 2) TRIÂNGULO(SIMPLIFICADO)

        // Console.WriteLine("Digite o tamanho do primeiro lado da forma: ");
        // int lado1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o tamanho do segundo lado da forma: ");
        // int lado2 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o tamanho do terceiro lado da forma: ");
        // int lado3 = int.Parse(Console.ReadLine());

        // if(lado1 > 0 && lado2 > 0 && lado3 > 0)
        // {
        //     Console.WriteLine("Pode formar um triângulo!");
        // }
        // else
        // {
        //     Console.WriteLine("Não pode formar um triângulo!");
        // }

        // 3) CALCULADORA SIMPLES

        // Console.WriteLine("Digite o primeiro número: ");
        // int num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // int num2 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite a operação que você deseja realizar(+, -, *, /): ");
        // string operacao = Console.ReadLine();

        // if(operacao == "+")
        // {
        //     Console.WriteLine(num1 + num2);
        // }
        // else if(operacao == "-")
        // {
        //     Console.WriteLine(num1 - num2);
        // }
        // else if(operacao == "*")
        // {
        //     Console.WriteLine(num1 * num2);
        // }
        // else if(operacao == "/")
        // {
        //     Console.WriteLine(num1 / num2);
        // }
        // else
        // {
        //     Console.WriteLine("Operação inválida!");
        // }

        // 4) LOGIN COM TENTATIVAS

        // Console.WriteLine("Digite o usuário: ");
        // string usuario = Console.ReadLine();

        // Console.WriteLine("Digite a senha: ");
        // string senha = Console.ReadLine();

        // if(usuario == "admin" && senha == "1234")
        // {
        //     Console.WriteLine("Acesso liberado!");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado!");
        // }

        // 5) TERNÁRIO ENCADEADO

        // Console.WriteLine("Digite um número: ");
        // int num = int.Parse(Console.ReadLine());

        // string classeNum = num == 0 ? "Zero" : num > 0 ? "Positivo" : "Negativo";

        // Console.WriteLine(classeNum);

        // 6) MENU DE OPERAÇÕES COMPLETO(SWITCH + IF)

        // Console.WriteLine("Digite o primeiro número: ");
        // int num1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número: ");
        // int num2 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite a operação que você deseja realizar(+, -, *, /): ");
        // string operacao = Console.ReadLine();
        
        // switch(operacao)
        // {
        //     case "+":
        //         Console.WriteLine(num1 + num2);
        //         break;

        //     case "-":
        //         Console.WriteLine(num1 - num2);
        //         break;

        //     case "*":
        //         Console.WriteLine(num1 * num2);
        //         break;

        //     case "/":
        //         Console.WriteLine(num1 == 0 || num2 == 0 ? "Zero" : num1 / num2);
        //         break;

        //     default:
        //         Console.WriteLine("Operação inválida!");
        //         break;
        // }

        // 7) ESCOLHA DE BEBIDA(SWITCH)

        // Console.WriteLine("[1] Água");
        // Console.WriteLine("[2] Refrigerante");
        // Console.WriteLine("[3] Suco");
        // Console.WriteLine("Selecione uma opção: ");
        // int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        // {
        //     case 1:
        //         Console.WriteLine("ÁGUA MINERAL: R$3,00");
        //         break;

        //     case 2:
        //         Console.WriteLine("COCA-COLA: R$8,00");
        //         break;

        //     case 3:
        //         Console.WriteLine("SUCO DE LARANJA: R$6,00");
        //         break;

        //     default:
        //         Console.WriteLine("Número inválido");
        //         break;
        // }
    }
}
