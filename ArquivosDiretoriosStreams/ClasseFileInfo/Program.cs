var caminhoOrigem = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\ClasseFileInfo\arquivo.txt";
var caminhoDestino = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\ClasseFileInfo\txt\arquivo.txt";
var caminhoCopia = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\ClasseFileInfo\arquivo_copia.txt";

// Criando uma instância da classe FileInfo para o arquivo especificado
FileInfo fileInfo = new FileInfo(caminhoOrigem);

// Exibindo informações sobre o arquivo
Console.WriteLine($"Nome do arquivo: {fileInfo.Name}");
Console.WriteLine($"Caminho completo: {fileInfo.FullName}");
Console.WriteLine($"É somente leitura? {fileInfo.IsReadOnly}");

// Obtendo o diretório pai do arquivo
var diretorioPai = fileInfo.Directory;

// Exibindo informações sobre o diretório pai
Console.WriteLine($"Nome do diretório: {diretorioPai.Name}");
Console.WriteLine($"Tamanho do arquivo: {fileInfo.Length} bytes");
Console.WriteLine($"Última gravação: {fileInfo.LastWriteTime}");

// Verificando se o arquivo existe
if (fileInfo.Exists)
{
    // Copiando o arquivo para outro local
    Console.WriteLine($"O {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    fileInfo.CopyTo(caminhoCopia, true);

    // Movendo o arquivo para outro local
    Console.WriteLine($"Movendo {caminhoOrigem} para {caminhoDestino}");
    fileInfo.MoveTo(caminhoDestino);
} else
    Console.WriteLine($"O {caminhoOrigem} arquivo não existe.");