using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Carro : Veiculo
    {
        // public string Marca;

        public string Modelo;

       //  public int Ano;

        // Métodos (Ações que a classe pode realizar)

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}