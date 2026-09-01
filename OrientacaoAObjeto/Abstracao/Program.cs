Quadrado quadrado = new Quadrado();
quadrado.Descricao();

quadrado.Cor = "Azul";
quadrado.Lado = 10;

quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado: {quadrado.Area} m2");
Console.WriteLine($"\nPerimetro do quadrado: {quadrado.Perimetro} m");

Console.WriteLine($"\nO quadrado tem a cor: {quadrado.Cor} m");