namespace POO;

class Program
{
    static void Main(string[] args)
    {
        // // Instanciando o objeto da classe carro

        // Carro meuCarro = new Carro();

        // // Definindo valores para os atributos

        // meuCarro.Marca = "Toyota";
        // meuCarro.Modelo = "Corolla";
        // meuCarro.Ano = 2022;

        // // Chamando o método

        // meuCarro.ExibirInformacoes();

        // ContaBancaria conta = new ContaBancaria();
        // conta.Sacar(100000);
        // conta.MostrarSaldo();

        Console.WriteLine($"----------------------------------");

        Cachorro c1 = new Cachorro();
        c1.nome = "Caramelo";
        c1.idade = 50;
        c1.raca = "Indefinida";
        c1.cor = "caramelo";
        c1.emitirSom();
        c1.mostrarDados();
        c1.comer();

        Console.WriteLine($"----------------------------------");
        
        Gato g1 = new Gato();
        g1.nome = "Feijão";
        g1.idade = 5;
        g1.raca = "Indefinida";
        g1.cor = "Marrom";
        g1.emitirSom();
        g1.mostrarDados();
        g1.comer();
    }
}
