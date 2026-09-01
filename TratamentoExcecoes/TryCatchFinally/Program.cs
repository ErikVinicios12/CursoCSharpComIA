using TryCatchFinally;

try
{
    Console.Write("Informe o dividendo: ");
    var dividendo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o divisor: ");
    var divisor = Convert.ToInt32(Console.ReadLine());

    if (divisor > 0)
        throw new MinhaException("Não pode usar 0");
     
    var resultado = dividendo / divisor;

    Console.WriteLine($"{dividendo} X {divisor} = {resultado}");
} catch (FormatException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday) { // só executará esta exceção se a condição When for atendida
    Console.WriteLine("\n Informe um valor inteiro"); // Exibe esta mensagem no console
    throw new FormatException("\n Informe um valor inteiro"); // exibe esta mensagem no erro
    throw; // Apenas sinaliza erro e passa para o próximo nivel
} catch (OverflowException) {
    Console.WriteLine("\n Informe um valor inteiro entre 1 e 999999");
    throw new OverflowException("\n Informe um valor inteiro entre 1 e 999999");
    throw;
} catch (DivideByZeroException) {
    Console.WriteLine("\n Não existe divisão por zero. Tente novamente");
    throw new DivideByZeroException("\n Não existe divisão por zero. Tente novamente");
    throw;
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex) {
    Console.WriteLine($"\n {ex.Message}");
    throw new Exception($"\n {ex.Message}");
    throw;
}
finally {

}