using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02
{
    internal class SalvarXml : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando XML");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome XML");
        }
    }
}
