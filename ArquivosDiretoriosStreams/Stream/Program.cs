string caminhoArquivo = @"C:\Users\Usuario\Documents\CursoCSharpComIA\ArquivosDiretoriosStreams\Stream\poesia.txt";

// Abrindo o arquivo para leitura
FileStream stream1 = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);

// Abrindo o arquivo para leitura usando File.Open
FileStream stream2 = File.Open(caminhoArquivo,FileMode.Open, FileAccess.Read);

// Abrindo o arquivo para leitura usando FileInfo
FileInfo filInfo = new FileInfo(caminhoArquivo);
FileStream stream3 = filInfo.Open(FileMode.Open, FileAccess.Read);

// Abrindo o arquivo para leitura usando a instrução using (desta maneira ele liberará o cash automaticamente)
using (FileStream stream4 = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read))
{

}

// Abrindo o arquivo para leitura usando a instrução using (desta maneira ele liberará o cash automaticamente) com a sintaxe simplificada do C# 8.0
using FileStream stream5 = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);