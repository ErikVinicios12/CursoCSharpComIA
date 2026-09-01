// Agregação é quando o filho não depende do pai (neste exemplo, Professor não depende do departamento)

using Agregacao;

Professor pf1 = new Professor("Carlos", "Quimica");
Professor pf2 = new Professor("Bruno", "Matematica");
Professor pf3 = new Professor("Alex", "Educação Fisica");
Professor pf4 = new Professor("Carla", "História");
Professor pf5 = new Professor("Fernando", "Português");

Departamento dp1 = new Departamento("Exatas");
dp1.incluirProfessor(pf1);
dp1.incluirProfessor(pf2);

Departamento dp2 = new Departamento("Humanas");
dp2.incluirProfessor(pf3);
dp2.incluirProfessor(pf4);
dp2.incluirProfessor(pf5);

dp1.ListaProfessores(); 
dp2.ListaProfessores();
