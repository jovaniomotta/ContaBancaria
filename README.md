Este é um projeto em C# (.NET) focado em demonstrar os fundamentos da Orientação a Objetos (POO). O sistema simula operações bancárias básicas,
dividindo as regras de negócio entre contas correntes e poupanças através de herança e polimorfismo.

- Funcionalidades

• Estrutura Base (Conta): Classe abstrata que gerencia as propriedades de Titular e Saldo, além dos métodos de Depositar, Sacar e Exibir Extrato.
• Conta Corrente (ContaCorrente): Aplica uma cobrança de Taxa de Manutenção ao final de cada mês.
• Conta Poupança (ContaPoupanca): Aplica uma Taxa de Rendimento sobre o saldo ao final de cada mês.
• Fim do Mês (FimDoMes): Método polimórfico implementado de forma personalizada por cada tipo de conta para atualizar seus saldos.

- Como executar

Altere os valores no Program.cs, e no terminal do Vs Code, rode com dotnet run para impressão dos valores.
