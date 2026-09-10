// Escreva o código para ler o conteúdo do arquivo "poesia.txt" localizado na pasta "ArquivosDiretoriosStreams/Stream"
// usando a classe FileStream e StreamReader e exibir o seu conteúdo na janela do Console

try
{
    using (FileStream stream = new FileStream(@"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Stream\poesia.txt", FileMode.Open, FileAccess.Read))
    {
        using (StreamReader reader = new StreamReader(stream))
        {
            string conteudo = reader.ReadToEnd();
            Console.WriteLine(conteudo);
        }
    }
} catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Acesso negado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}