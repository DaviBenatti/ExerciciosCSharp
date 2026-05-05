using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Animal
    {
        public string nome;
        public int idade;
        public string raca;
        public string cor;

        // Virtual = O método será sobrescrito
        public virtual void emitirSom()
        {
            Console.WriteLine($"O animal faz um som");
        }

        public void mostrarDados()
        {
            Console.WriteLine($"Nome: " + nome);
            Console.WriteLine($"Idade: " + idade);
            Console.WriteLine($"Raça: " + raca);
            Console.WriteLine($"Cor: " + cor);
        }

        public abstract void comer();
    }
}