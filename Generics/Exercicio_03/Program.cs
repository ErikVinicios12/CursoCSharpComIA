using Exercicios_03;

EditorTexto texto = new EditorTexto();

while (true)
{
    var action = 0;
    Console.Write("\n [1] Digitar\n" +
        " [2] Excluir\n" +
        " [3] Sair\n" +
        "R: ");
    action = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            Console.Write("\nDigite um caracter: ");
            var valor = Convert.ToChar(Console.ReadLine());
            texto.DigitarChat(valor);
            break;
        case 2:
            texto.Undo();
            break;
        case 3:
            return;
    }
}