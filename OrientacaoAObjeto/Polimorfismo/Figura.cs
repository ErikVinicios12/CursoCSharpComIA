using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Figura
    {
        public virtual void Desenhar() {
            Console.WriteLine("Exercutando desenhar na classe base");
        }
    }
}
