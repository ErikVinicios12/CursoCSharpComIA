using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SerializacaoJSON
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        [JsonIgnore] // ignora a serialização de Idade
        public int Idade { get; set; }

        public Aluno() { } // Este construtor vazio é necessario na serializacao JSON

        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
