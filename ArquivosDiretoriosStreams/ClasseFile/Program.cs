string caminhoOrigem = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\ClasseFile\arquivo.txt";
string caminhoDestino = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\ClasseFile\txt\arquivo.txt";

if (!File.Exists(caminhoDestino))
{
	try
	{
        // Cria o arquivo e escreve o conteúdo inicial
        File.WriteAllText(caminhoOrigem, "Fernando Pessoa \r\n");

		string novoTexto = "O poeta é um fingidor" +
			Environment.NewLine + "Finge tão completamente" +
			Environment.NewLine + "Que chega a fingir que é dor" +
			Environment.NewLine + "A dor que deveras sente";

        // Adiciona o novo texto ao final do arquivo existente
        File.AppendAllText(caminhoOrigem, novoTexto);

        // Lê o conteúdo do arquivo e exibe no console
        Console.WriteLine("\n Conteúdo do Arquivo\n");
		string conteudo = File.ReadAllText(caminhoOrigem);
		Console.WriteLine(conteudo);

        // Exibe informações sobre o arquivo
        Console.WriteLine("Última modificação feita em: " + File.GetLastWriteTime(caminhoOrigem));
		Console.WriteLine("Último acesso feito em: " + File.GetLastAccessTime(caminhoOrigem));

        // Lê todas as linhas do arquivo e exibe no console
        string[] linhas = File.ReadAllLines(caminhoOrigem);
		Console.WriteLine("\n Linhas do Arquivo\n");
		foreach (string linha in linhas)
		{
			Console.WriteLine(linha);
		}

        // Copia o arquivo para um novo local
        var caminhoCopia = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\ClasseFile\arquivo_copia.txt";
		File.Copy(caminhoOrigem, caminhoCopia, true);

        // Move o arquivo para o destino especificado
        File.Move(caminhoOrigem, caminhoDestino);

        // Exclui os arquivos criados para limpeza
        File.Delete(caminhoOrigem);
		File.Delete(caminhoCopia);
		File.Delete(caminhoDestino);
    }
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}