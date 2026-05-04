using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Veiculo
    {
        public string Marca;

        public int Ano;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Veículo: {Marca}, Ano: {Ano}");
        }
    }
}