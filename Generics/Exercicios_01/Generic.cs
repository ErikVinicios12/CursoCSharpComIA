using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_01
{
    public class Generic<T>
    {
        private T[] _lista;
        private int _indexer;
        public Generic() {
            _lista = new T[5];
            _indexer = 0;
        }

        public bool Adicionar(T item) {
            try
            {
                _lista[_indexer] = item;
                _indexer++;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int Count()
        {
            return _lista.Length;
        }

        public T this[int index] // Com isso, eu consigo exibir os resultados de _lista sem precisar criar um método e sem deixar _lista como pública
        {                        // Apenas faço Generic[index]
            get { return _lista[index]; }
            set { _lista[index] = value; }
        }
    }
}
