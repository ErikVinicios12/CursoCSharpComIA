public static class ListExtensions
{
    public static int SomarImpares(this List<int> list)
    {
        int soma = 0;
        foreach (int numero in list)
        {
            if (numero % 2 != 0)
            {
                soma += numero;
            }
        }
        return soma;
    }
}