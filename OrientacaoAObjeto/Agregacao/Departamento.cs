using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacao
{
    public class Departamento
    {
        public string? Nome { get; set; }

        private List<Professor>? Professores { get; set; }

        public Departamento(string? nome) {
            Nome = nome;
            Professores = new List<Professor>();
        }

        public void incluirProfessor(Professor professor)
        {
            Professores?.Add(professor);
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"\nDepartamento de : {Nome}");

            foreach (Professor prof in Professores) {
                Console.WriteLine($"{prof.Nome} -> {prof.Disciplina}");
            }
        }
    }
}
