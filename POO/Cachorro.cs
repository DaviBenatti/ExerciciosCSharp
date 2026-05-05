using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Cachorro : Animal
    {
        public override void comer()
        {
            Console.WriteLine($"O cachorro está comendo um petisco Pedigree...");
            
        }
        // Override = Redefinir um método herdado.
        public override void emitirSom()
        {
            Console.WriteLine($"Au Au!");
        }
    }
}