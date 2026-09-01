using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class Carro : IVeiculo
    {
        public int QntCombustivel { get; set; }
        public Carro(int QuantidadeInicial)
        {
            QntCombustivel = QuantidadeInicial;
        }

        public bool Abastecer(int quantidade)
        {
            QntCombustivel += quantidade;
            Console.WriteLine("Veiculo abastecido! ");
            return true;
        }

        public void Dirigir()
        {
            if (QntCombustivel > 0)
                Console.WriteLine("Dirigindo o carro...");
            else
                Console.WriteLine("Sem gasolina.");
        }
    }
}
