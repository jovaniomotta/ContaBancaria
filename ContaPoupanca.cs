 public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular, decimal saldoInicial) : base(titular, saldoInicial) { }

        public override void FimDoMes()
        {
            Saldo += Saldo * 0.01m; // Rendimento de 1% ao mês
            Console.WriteLine($"Rendimento de 1% (R$ {Saldo * 0.01m:F2}) aplicado na Conta Poupança de {Titular}. Saldo atual: R$ {Saldo:F2}");
        }   

        public override void ExibirExtrato()
        {
            base.ExibirExtrato();
            Console.WriteLine("----------------------------\n");
        }
    }
