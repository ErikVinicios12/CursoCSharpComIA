using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_03
{
    internal class EditorTexto
    {
        private Stack<char> undoStack = new Stack<char>();
        private string texto;

        public void DigitarChat(char c)
        {
            texto += c;
            undoStack.Push(c);
            Console.WriteLine($"\nTexto: {texto}");
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                undoStack.Pop();
                texto = texto.Substring(0, texto.Length - 1);
                Console.WriteLine($"\nTexto: {texto}");
            }
        }
    }
}
