string caminhoDiretorio = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03";

//1- Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo 
//existe. Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem 
//informando que o arquivo não foi encontrado. 
//string caminho = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\arquivo.txt";

//if (File.Exists(caminho))
//{
//    FileInfo fileInfo = new FileInfo(caminho);
//    Console.WriteLine($"O arquivo existe. Data de criação: {fileInfo.CreationTime}");
//}
//else
//    Console.WriteLine("O arquivo não foi encontrado.");



//2- Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de 
//origem e destino devem ser fornecidos pelo usuário. 
//Console.WriteLine("Digite o caminho do arquivo de origem:");
//string origem = Console.ReadLine();
//Console.WriteLine("Digite o caminho do arquivo de destino:");
//string destino = Console.ReadLine();

//try
//{
//    File.Copy(origem, destino);
//    Console.WriteLine("Arquivo copiado com sucesso!");
//}
//catch (Exception ex)
//    Console.WriteLine($"Ocorreu um erro ao copiar o arquivo: {ex.Message}");



//3- Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo 
//novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na 
//tela. 
//string caminhoArquivo = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\arquivo.txt";
//using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write))
//{
//    using (StreamWriter writer = new StreamWriter(stream))
//    {
//        writer.WriteLine("Informações iniciais do arquivo.");
//    }
//}
//;

//using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
//{
//    writer.WriteLine("Texto acrescentado");
//}

//using (StreamReader reader = new StreamReader(caminhoArquivo))
//{
//    string conteudo = reader.ReadToEnd();
//    Console.WriteLine("Conteúdo do arquivo:");
//    Console.WriteLine(conteudo);
//}



//4- Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de 
//criptografia AES. Em seguida, salve o arquivo criptografado em um novo arquivo. O nome do arquivo de 
//origem e destino deve ser fornecido pelo usuário. 
//using System.Security.Cryptography;
//using System.Text;

//string caminhoArquivoOrigem = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\arquivo.txt";
//string caminhoArquivoDestino = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\arquivo_criptografado.bin";

//using (FileStream streamOrigem = new FileStream(caminhoArquivoOrigem, FileMode.Open, FileAccess.Read))
//{
//    using (FileStream streamDestino = new FileStream(caminhoArquivoDestino, FileMode.Create, FileAccess.Write))
//    {
//        using (Aes aes = Aes.Create())
//        {
//            aes.Key = Encoding.UTF8.GetBytes("1234567890123456"); // Chave de 16 bytes
//            aes.IV = Encoding.UTF8.GetBytes("1234567890123456"); // Vetor de inicialização de 16 bytes
//            using (CryptoStream cryptoStream = new CryptoStream(streamDestino, aes.CreateEncryptor(), CryptoStreamMode.Write))
//            {
//                streamOrigem.CopyTo(cryptoStream);
//            }
//        }
//    }
//}



//5- Escreva um programa que leia o conteúdo de um arquivo de imagem e converta-o para um arquivo de texto 
//usando o algoritmo de codificação Base64. Em seguida, salve o arquivo de texto em um novo arquivo. O 
//nome do arquivo de origem e destino deve ser fornecido pelo usuário. 
//string caminhoArquivoImagem = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\imagem.jpg";

//using (FileStream streamImagem = new FileStream(caminhoArquivoImagem, FileMode.Open, FileAccess.Read))
//{
//    byte[] bytesImagem = new byte[streamImagem.Length];
//    streamImagem.Read(bytesImagem, 0, bytesImagem.Length);
//    string base64String = Convert.ToBase64String(bytesImagem);
//    string caminhoArquivoTexto = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\imagem_base64.txt";
//    using (StreamWriter writer = new StreamWriter(caminhoArquivoTexto))
//    {
//        writer.Write(base64String);
//    }
//}



//6- Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a 
//classe Path. 
//DirectoryInfo diretorioInfo = new DirectoryInfo(caminhoDiretorio);
//foreach (var arquivo in diretorioInfo.GetFiles())
//{
//    Console.WriteLine($"Arquivo: {arquivo.Name}, Caminho: {arquivo.FullName}");
//}



//7- Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe 
//DirectoryInfo. 
//DirectoryInfo directoryInfo = new DirectoryInfo(caminhoDiretorio);

//foreach (var subdiretorio in directoryInfo.GetDirectories())
//{
//    Console.WriteLine($"Subdiretório: {subdiretorio.Name}, Caminho: {subdiretorio.FullName}");
//}



//8- Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro 
//desse diretório usando a classe Directory e a classe Path. 
//string caminhoNovoDiretorio = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\NovoDiretorio";
//Directory.CreateDirectory(caminhoNovoDiretorio);
//File.Create(Path.Combine(caminhoNovoDiretorio, "novo_arquivo.txt")).Close();



//9- Criar um programa que permita ao usuário copiar um arquivo de um diretório para outro usando a classe File 
//e a classe Path. 
//string caminhoArquivoOrigem = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\arquivo.txt";
//string caminhoArquivoDestino = Path.Combine(@"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\NovoDiretorio", "arquivo_copiado.txt");
//File.Copy(caminhoArquivoOrigem, caminhoArquivoDestino);



//10- Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File 
//e a classe Path. 
//string caminhoArquivoOrigem = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\arquivo.txt";
//string caminhoArquivoDestino = Path.Combine(@"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Exercicios_03\NovoDiretorio", "arquivo_movido.txt");

//File.Move(caminhoArquivoOrigem, caminhoArquivoDestino);



//11- Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a 
//classe DirectoryInfo e a classe Path. 
//DirectoryInfo directoryInfo = new DirectoryInfo(caminhoDiretorio);

//foreach (var arquivo in directoryInfo.GetFiles("*", SearchOption.AllDirectories))
//{
//    Console.WriteLine($"Arquivo: {arquivo.Name}, Caminho: {arquivo.FullName}");
//}



//12-  Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a 
//classe DirectoryInfo e a classe Path. 
//DirectoryInfo directoryInfo = new DirectoryInfo(caminhoDiretorio);
//string caminho = directoryInfo.FullName;
//caminho = Path.Combine(caminho, "imagem_base64.txt");

//File.Delete(caminho);
//Directory.Delete(Path.Combine(caminhoDiretorio, "NovoDiretorio"), true);



//13-  Criar um programa que renomeie um arquivo usando a classe File e a classe Path. 
//var imagem = Path.Combine(caminhoDiretorio, "imagem.jpg");
//File.Move(imagem, Path.Combine(caminhoDiretorio, "paisagem.jpg"));



//14-  Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e 
//subdiretórios, usando a classe Directory e a classe Path. 
//DirectoryInfo directoryInfo = new DirectoryInfo(caminhoDiretorio);

//Console.WriteLine("Tamanho total do diretório: " + GetDirectorySize(directoryInfo) + " bytes");

//long GetDirectorySize(DirectoryInfo directoryInfo)
//{
//    return directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(x => x.Length);
//}



//15-  Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe 
//DirectoryInfo e a classe Path.
//DirectoryInfo directoryInfo = new DirectoryInfo(caminhoDiretorio);
//FileInfo arquivoRecente = directoryInfo.GetFiles().OrderByDescending(f => f.LastWriteTime).FirstOrDefault();
//Console.WriteLine($"Arquivo mais recente: " + arquivoRecente.Name);