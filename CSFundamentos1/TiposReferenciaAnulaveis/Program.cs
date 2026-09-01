Console.WriteLine(" Tipos de referencia anuláveis ");

string? nome = null; // ou string nome = ""
Console.WriteLine(nome?.ToUpper()); // se nome não for null, ele aplica .ToUpper()