using Exercicios_01;

//Escrever um programa onde devemos usar os conceitos de abstração, encapsulamento e herança para expressar o comportamento de contas bancárias
//considerando o seguinte cenário:
//
//Em um banco temos clientes que possuem contas que são identificadas por um número e Nome do cliente.
//
//As operações que serão permitidas são as operações básicas de depositar, sacar e exibir o saldo
//
//Devemos considerar 3 tipos de contas:
//1- contas correntes comuns: São contas comuns dos clientes e realizam todas as operações básicas
//2- contas de poupança: São contas especificar que se destacam por possuirem juros mensais que são aplicados ao saldo da conta
//3- contas de investimentos: São contas especificas que se destacam por possuir uma taxa de remuneração que é aplicado ao saldo da conta e uma
//taxa de impostos que é descontado do saldo da conta
//
//Para simplificar o exercício considere as seguintes premissas:
//a- O saldo inicial das contas é zero;
//b- O juros da conta de poupança é 0,5% e os rendimentos devem ser calculados ao se efetuar um deposito e deve ser acrescido ao saldo da conta;
//c- taxa da conta de investimento é 0,9% e deve ser aplicada a cada depósito e acrescida ao saldo
//d- O impostom da conta de investimento é 0,1% e deve ser aplicado a cada saque na conta e debitado do saldo;
//e- As contas de póupança e de investimento não permitem que o saldo da conta fique negativo;

Cliente c1 = new Cliente();
c1.Nome = "Erik";
c1.Numero = 10;
c1.Tipo = TiposContas.ContaInvestimento;

while (true)
{
    try
    {
        Console.Write("O que deseja fazer?\n" +
                "[1] Deposito\n" +
                "[2] Saque\n" +
                "[3] Exibir saldo\n" +
                "[4] Sair\n" +
                "R: ");
        var opt = Convert.ToInt32(Console.ReadLine());

        if (opt == 4)
        {
            Console.WriteLine("\nPrograma finalizado.");
            break;
        }

        switch (opt)
        {
            case 1:
                Console.Write("Valor do deposito: ");
                var v = Convert.ToDecimal(Console.ReadLine());
                var result1 = c1.Depositar(v);
                if (result1)
                    Console.WriteLine("\n Deposito feito! \n");
                continue;
            case 2:
                Console.Write("Valor do saque: ");
                var s = Convert.ToDecimal(Console.ReadLine());
                var result2 = c1.Sacar(s);
                if (result2)
                    Console.WriteLine("\n Saque feito! \n");
                else
                    Console.WriteLine("\n Saldo insuficiente! \n");
                continue;
            case 3:
                c1.ExibirSaldo();
                continue;
        }
    } catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
}