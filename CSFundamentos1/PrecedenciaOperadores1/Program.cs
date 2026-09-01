Console.WriteLine(" Precedência de operadores ");

bool z = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(z);

int a = 5, b = 6, c = 4;
int r = --a * b - ++c;
Console.WriteLine(r);

r = a = b = c; // da direita pra esquerda
