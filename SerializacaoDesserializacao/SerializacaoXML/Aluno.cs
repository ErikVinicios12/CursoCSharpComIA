using System;
using System.Collections.Generic;
using System.Text;

namespace SerializacaoXML
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade;

        public Aluno() { } // Este construtor vazio é necessario na serializacao XML
         
        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
