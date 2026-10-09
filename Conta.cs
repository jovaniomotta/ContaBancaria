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
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso na conta de {Titular}.");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
                return;
            }

            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso por {Titular}.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para o saque de R$ {valor:F2} (Saldo atual: R$ {Saldo:F2}).");
            }
        }

        public virtual void ExibirExtrato()
        {
            Console.WriteLine($"--- Extrato de {Titular} ---");
            Console.WriteLine($"Saldo Atual: R$ {Saldo:F2}");
        }

        public abstract void FimDoMes();
    }
