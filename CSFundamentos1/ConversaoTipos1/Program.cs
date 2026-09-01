Console.WriteLine("## Conversão de tipos ##!");

int varInt = 100;             //int usa 4 bytes
double varDouble = varInt;    //double usa 8 bytes


// byte -> 1 byte
// short -> 2 byte
// int -> 4 byte
// long -> 8 byte
// float -> 4 byte
// double -> 8 byte
// decimal -> 16 byte

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

double varDouble2 = 12.456;         //8 bytes
int varInt2 = (int)varDouble2;      //4 bytes (perda de precisão)
Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;
float resultado = (float) num1 / num2; // 10 / 4 = 2.5

Console.WriteLine(resultado);