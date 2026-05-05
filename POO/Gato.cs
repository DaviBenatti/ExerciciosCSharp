using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Gato : Animal
    {
        public override void comer()
        {
            Console.WriteLine($"O gato está comendo petisco Whiskas...");
        }
        public override void emitirSom()
        {
            Console.WriteLine($"Miauuuuu!");
        }
    }
}