using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Triangulo");
            base.Desenhar();
        }
    }
}
