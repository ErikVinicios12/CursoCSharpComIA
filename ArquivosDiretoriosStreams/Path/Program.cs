string path1 = @"C:\Users\Usuario\Documents\CursoCSharpComIA";
string path2 = @"\ArquivosDiretoriosStreams\Path\arquivo.txt";

string pathCombined = Path.Combine(path1, path2);
Console.WriteLine($"Caminho combinado: {pathCombined}");

Console.WriteLine("\nInformações sobre o caminho combinado:");
Console.WriteLine($"Nome do diretório: {Path.GetFileName(pathCombined)}");
Console.WriteLine($"Extensão do arquivo: {Path.GetExtension(pathCombined)}");
Console.WriteLine($"Nome do arquivo: {Path.GetFileNameWithoutExtension(pathCombined)}");
Console.WriteLine($"Nome do arquivo sem extensão: {Path.GetDirectoryName(pathCombined)}");
Console.WriteLine($"Possui extensão: {Path.HasExtension(pathCombined)}");
Console.WriteLine($"Contêm a raiz: {Path.IsPathRooted(pathCombined)}");
Console.WriteLine($"Nova extensão: {Path.ChangeExtension(pathCombined, ".txt")}");
Console.WriteLine($"Raiz: {Path.GetPathRoot(pathCombined)}");

Console.WriteLine($"Nome do arquivo aleatório: {Path.GetRandomFileName()}");
Console.WriteLine($"Nome do arquivo temporário: {Path.GetTempFileName()}");
Console.WriteLine($"Caminho temporário: {Path.GetTempPath()}");

char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();
Console.WriteLine($"Caracteres inválidos em nomes de arquivo: {new string(caracteresInvalidosEmArquivo)}");
