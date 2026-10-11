public abstract class Conta

{
        
        private static int _totalContas = 0;
        //private static int _totalContas = 0; // Contador de contas criadas

        public string Titular { get; }
       
        public decimal Saldo { get; protected set; }

        public static int TotalContas => _totalContas;

        
        public Conta(string titular) : this(titular, 0m)
        {
        }

        
        public Conta(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
            _totalContas++; 
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            throw new ArgumentException("O valor do depósito deve ser positivo.");
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso por {Titular}. Saldo atual: R$ {Saldo:F2}");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser positivo.");
            }

            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso por {Titular}. Saldo atual: R$ {Saldo:F2}");
        }

        public virtual void ExibirExtrato()
        {
            Console.WriteLine($"--- Extrato de {Titular} ---");
            Console.WriteLine($"Saldo Atual: R$ {Saldo:F2}");
        }

        public abstract void FimDoMes();

    internal static object GetTotalContas()
    {
        throw new NotImplementedException();
    }
}
