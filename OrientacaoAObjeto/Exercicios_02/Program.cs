// Criar um programa C# que usa interfaces para salvar arquivos nos formatos Xml e Json
//
//- Criar a interface ISalvar definindo o método abstrato Salvar()
//- Criar uma classe abstrata ArquivoBase e definir um método virtual Nome()
//- Criar as classes SalvarXml e SalvarJson e herdar a classe base e implementar a interface duas classes
//- Testar a implementação
//- Incluir o método não abstrato Compactar() na interface definindo uma implementação
//0 Acessar este método

using Exercicios_02;

SalvarXml sXML = new SalvarXml();
sXML.Salvar();
sXML.Nome();

SalvarJson sJSON = new SalvarJson();
sJSON.Salvar();
sJSON.Nome();

ISalvar save = new SalvarJson();
save.Compactar();
