using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public interface IVeiculo
    {
        public int QntCombustivel { get; set;  }
        public void Dirigir();
        public bool Abastecer(int quantidade);
    }
}
