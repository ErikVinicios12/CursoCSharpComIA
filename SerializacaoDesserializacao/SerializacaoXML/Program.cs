using SerializacaoXML;
using System.Xml.Serialization;

Aluno aluno1 = new Aluno(1, "Maria", "Maria@gmail.com", 17);
string caminhoArquivo = @"C:\Users\Usuario\Documents\CursoCSharpComIA\SerializacaoDesserializacao\SerializacaoXML\AlunoSerializado.xml";

// Cria um XmlSerializer para o tipo Aluno
XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, aluno1);
}
Console.WriteLine("Objeto serielizado com sucesso!");

using (StreamReader reader = new StreamReader(caminhoArquivo))
{
    var aluno = (Aluno)serializer.Deserialize(reader);
}

Console.WriteLine("Objeto deserializado com sucesso!");