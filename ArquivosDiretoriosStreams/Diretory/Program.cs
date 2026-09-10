var caminhoDiretorio = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Diretory\MeuDiretorio";
var caminhoDestino = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Diretory\MeuDiretorioNovo";

try
{
    if (!Directory.Exists(caminhoDiretorio))
    {
        // Criando o diretório
        Directory.CreateDirectory(caminhoDiretorio);
        Console.WriteLine($"Diretório criado: {caminhoDiretorio}");

        // Listando subdiretórios
        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio);
        foreach (var subdiretorio in subdiretorios)
        {
            Console.WriteLine($"Subdiretório: {subdiretorio}");
        }

        // Listando arquivos que começam com a letra "p"
        string[] arquivos = Directory.GetFiles(caminhoDiretorio, "p*");
        foreach (var arquivo in arquivos)
        {
            Console.WriteLine($"Arquivo: {arquivo}");
        }

        // Movendo o diretório para outro local
        Directory.Move(caminhoDiretorio, caminhoDestino);
        Console.WriteLine($"Diretório movido para: {caminhoDestino}");
    }
    else
    {
        // O diretório já existe, então vamos deletá-lo
        Directory.Delete(caminhoDiretorio, true);
        Directory.Delete(caminhoDestino, true);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}