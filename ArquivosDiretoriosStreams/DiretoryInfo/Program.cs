var caminhoDiretório = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\DiretoryInfo\MeuDiretorio";

var diretório = new DirectoryInfo(caminhoDiretório);
try
{
    if (diretório.Exists)
    {
        // Exibir informações do diretório
        Console.WriteLine($"Informações do diretório: {diretório.FullName}");
        Console.WriteLine($"Nome: {diretório.Name}");
        Console.WriteLine($"Raiz: {diretório.Root}");
        Console.WriteLine($"Última modificação: {diretório.LastWriteTime}");
        Console.WriteLine($"Atributos: {diretório.Attributes}");

        // Listar subdiretórios
        foreach (var subdir in diretório.GetDirectories())
        {
            Console.WriteLine($"Subdiretório: {subdir.Name}");
        }

        // Listar arquivos
        foreach (var arquivo in diretório.GetFiles())
        {
            Console.WriteLine($"Arquivo: {arquivo.Name}");
        }

        // Criar um subdiretório
        diretório.CreateSubdirectory("SubDiretorio1");
    }
    else
    {
        // Criar o diretório se ele não existir
        diretório.Create();
        Console.WriteLine("Diretorio criado com sucesso!");
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    // Excluir o diretório
    diretório.Delete();
}