namespace Exercicios_01
{
    public class Conta
    {
        public int Numero { get; set; }
        private int _tipo;
        public TiposContas Tipo { get { return (TiposContas)_tipo; } set { _tipo = (int)value; } }
        private decimal _saldo;

        public Conta()
        {
            _saldo = 0;
        }

        public bool Depositar(decimal valor)
        {
            _saldo += valor;
            if (_tipo == (int)TiposContas.ContaPoupanca)
                _saldo *= 1.05m;

            if (_tipo == (int)TiposContas.ContaInvestimento)
                _saldo += _saldo * 0.09m;
            return true;
        }

        public bool Sacar(decimal valor)
        {
            if (valor > _saldo && (_tipo == (int)TiposContas.ContaInvestimento || _tipo == (int)TiposContas.ContaPoupanca))
                return false;

            _saldo -= valor;
            if (_tipo == (int)TiposContas.ContaInvestimento)
                _saldo -= valor * 0.01m;

            return true;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\n Saldo: {_saldo.ToString("C")}\n");
        }
    }
}
