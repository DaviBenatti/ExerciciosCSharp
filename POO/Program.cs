namespace POO;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando o objeto da classe carro

        Carro meuCarro = new Carro();

        // Definindo valores para os atributos

        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2022;

        // Chamando o método

        meuCarro.ExibirInformacoes();
    }
}
