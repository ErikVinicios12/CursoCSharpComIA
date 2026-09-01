using Enumeracao_ENUM;

Console.WriteLine(DiasDaSemana.Domingo);
Console.WriteLine(DiasDaSemana.Terça);

int dia1 = (int)DiasDaSemana.Domingo;
int dia2 = (int)DiasDaSemana.Terça;

Console.WriteLine($"Domingo: {dia1}\n" +
    $"Terça: {dia2}");

Console.WriteLine($"\n{Categorias.Moda} = {(int)Categorias.Moda}\n" +
    $"{Categorias.Automotivo} = {(int)Categorias.Automotivo}\n" +
    $"{Categorias.Artes} = {(int)Categorias.Artes}\n" +
    $"{Categorias.Bebidas} = {(int)Categorias.Bebidas}\n" +
    $"{Categorias.Livros} = {(int)Categorias.Livros}\n" +
    $"{Categorias.Brinquedos} = {(int)Categorias.Brinquedos}");

Console.Write("\nSelecione a categoria teclando o valor: ");
var categoria = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você selecionou a categoria: " + (Categorias)categoria);