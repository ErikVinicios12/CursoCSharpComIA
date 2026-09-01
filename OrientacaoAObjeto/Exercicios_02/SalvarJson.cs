using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02
{
    internal class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando Json");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome Json");
        }
    }
}
