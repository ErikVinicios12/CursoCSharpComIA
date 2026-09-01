// Polimorfismo significa "Muitas formas". 
// As classes derivadas de uma mesma classe base podem invocar métodos que tem a mesma assinatura mas comportamentos
// distintos, que são especializados para cada classe derivada, usando para tanto uma referência a um objeto do tipo da classe base

using Polimorfismo;

// Exemplo 1

var figuras = new List<Figura>()
{
    new Circulo(),
    new Triangulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}

// Exemplo 2 (sobrecarga)

Calcular calc = new Calcular();

Console.WriteLine(calc.Somar(30, 40));
Console.WriteLine(calc.Somar(30, 40, 50));
