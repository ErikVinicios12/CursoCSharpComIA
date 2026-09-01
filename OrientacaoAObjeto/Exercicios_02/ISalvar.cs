using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02
{
    interface ISalvar
    {
        void Salvar();

        void Compactar()
        {
            Console.WriteLine("Compactando...");
        }
    }
}
