   public class ContaCorrente : Conta
    {
        private decimal Limite = 500m;

        public ContaCorrente(string titular, decimal saldoInicial) : base(titular, saldoInicial) { }

        public ContaCorrente(string titular) : base(titular) { }

               public override void Sacar(decimal valor)
            {
           
            if (valor <= Saldo + Limite)
            throw new SaldoInsuficienteException($"Saldo insuficiente para o saque de R$ {valor:F2} (Saldo atual: R$ {Saldo:F2}, Limite disponível: R$ {Limite:F2}).");
                Saldo -= valor;

            }
        

        public override void FimDoMes()
        {
            Saldo -= 10; // Tarifa mensal de R$ 10,00;
            Console.WriteLine($"Tarifa mensal de R$ 10,00 aplicada na Conta Corrente de {Titular}. Saldo atual: R$ {Saldo:F2}");
        }

        public override void ExibirExtrato()
        {
            base.ExibirExtrato();
            Console.WriteLine($"Limite Disponível: R$ {Limite:F2}");
            Console.WriteLine($"Total Disponível para Saque: R$ {Saldo + Limite:F2}");
            Console.WriteLine("----------------------------\n");
        }
    }
