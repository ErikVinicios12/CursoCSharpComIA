// Crie um programa que ofereça um menu de opções para maninupulação de um arquivo texto utilizando as classes FileStream, StreamReader e StreamWriter.
// As opções do menu devem ser:
//1- Criar arquivo: permite criar um novo arquivo texto, caso ele não exista, ou sobrescrever um arquivo existente.
//2- Gravas no arquivo: permite adicioonar conteúdo ao arquivo. O usuário deve poder digitar o conteúdo que deseja adicionar ao arquivo.
//3- Ler arquivo: exibe op conteúdo completo do arquivo na tela
//4- Procurar no arquivo: permite procurar um texto no arquivo e exibir a posição da primeira ocorrência na tela. O usuário deve poder digitar o
//texto a ser procurado

try
{
    string caminhoArquivo = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_02\arquivo.txt";
    while (true)
	{
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1- Criar novo arquivo");
        Console.WriteLine("2- Gravar no arquivo");
        Console.WriteLine("3- Ler arquivo");
        Console.WriteLine("4- Procurar no arquivo");
        Console.WriteLine("5- Sair");
        var opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                CriarArquivo(caminhoArquivo);
                break;
            case "2":
                GravarNoArquivo(caminhoArquivo);
                break;
            case "3":
                LerArquivo(caminhoArquivo);
                break;
            case "4":
                ProcurarNoArquivo(caminhoArquivo);
                break;
            case "5":
                return;
            default:
                Console.WriteLine("\n Opção inválida.");
                break;
        }   
	}
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}

void ProcurarNoArquivo(string caminhoArquivo)
{
    using (StreamReader reader = new StreamReader(caminhoArquivo))
    {
        var conteudo = reader.ReadToEnd();
        Console.WriteLine("\nDigite o texto que deseja procurar no arquivo:");
        var textoProcurado = Console.ReadLine();
        var posicao = conteudo.IndexOf(textoProcurado);
        if (posicao >= 0)
        {
            Console.WriteLine($"\n O texto '{textoProcurado}' foi encontrado na posição {posicao}.");
        }
        else
        {
            Console.WriteLine($"\n O texto '{textoProcurado}' não foi encontrado no arquivo.");
        }
    }
}

void LerArquivo(string caminhoArquivo)
{
    using (StreamReader reader = new StreamReader(caminhoArquivo))
    {
        var conteudo = reader.ReadToEnd();
        Console.WriteLine("\n Conteúdo do arquivo:");
        Console.WriteLine(conteudo);
    }
}

void GravarNoArquivo(string caminhoArquivo)
{
    using (StreamWriter writer = new StreamWriter(caminhoArquivo))
    {
        Console.WriteLine("\nDigite o conteúdo que deseja adicionar ao arquivo:");
        var conteudo = Console.ReadLine();
        writer.WriteLine(conteudo);
    }
}

void CriarArquivo(string caminhoArquivo)
{
    if (!File.Exists(caminhoArquivo))
    {
        using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.ReadWrite))
        {
            Console.WriteLine("\n Arquivo criado com sucesso.");
        }
    }
    else
    {
        using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Truncate, FileAccess.ReadWrite))
        {
            Console.WriteLine("\n Arquivo criado com sucesso.");
        }
    }
}