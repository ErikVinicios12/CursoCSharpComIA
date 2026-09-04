using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public static class StringExtensions
    {
        public static string InverteString(this string str) // a palavra this indica que o método é um método de extensão para a classe string
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
