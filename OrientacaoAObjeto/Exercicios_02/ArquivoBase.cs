using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02
{
    public abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Nome padrão");
        }
    }
}
