using SerializacaoJSON;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

Aluno aluno1 = new Aluno(1, "Maria", "Maria@gmail.com", 17);
string caminhoArquivo = @"C:\Users\Usuario\Documents\CursoCSharpComIA\SerializacaoDesserializacao\SerializacaoJSON\AlunoSerializado.json";

using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno1);
}
Console.WriteLine("Objeto serielizado com sucesso!");

string jsonContent = File.ReadAllText(caminhoArquivo);
var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine("Objeto deserializado com sucesso!");