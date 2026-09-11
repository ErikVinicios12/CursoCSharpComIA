using Exercicios_01;
using System.Text.Json;
using System.Xml.Serialization;

List<Aluno> alunos = new List<Aluno>()
{
    new Aluno(1, "Maria", "maria@gmail.com", 22),
    new Aluno(2, "Ana", "ana@gmail.com", 19),
    new Aluno(3, "pedro", "pedro@gmail.com", 42),
};

string caminhoJSON = @"C:\Users\Usuario\Documents\CursoCSharpComIA\SerializacaoDesserializacao\Exercicios_01\alunos.json";
string caminhoXML = @"C:\Users\Usuario\Documents\CursoCSharpComIA\SerializacaoDesserializacao\Exercicios_01\alunos.xml";

using (FileStream file = new FileStream(caminhoJSON, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(file, alunos);
}

Console.WriteLine("Serialização em JSON feita com sucesso!");

XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aluno>));

using (StreamWriter writer = new StreamWriter(caminhoXML))
{
    xmlSerializer.Serialize(writer, alunos);
}

Console.WriteLine("Serialização em XML feita com sucesso!");