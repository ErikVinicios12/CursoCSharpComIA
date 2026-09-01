using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    public class LivroFotos
    {
        protected int _numPaginas;

        public LivroFotos()
        {
            _numPaginas = 16;
        }
        
        public LivroFotos(int numPaginas)
        {
            _numPaginas = numPaginas;
        }
        public void GetNumeroPaginas()
        {
            Console.WriteLine($"Este álbum possui {_numPaginas} páginas; ");
        }
    }
}
