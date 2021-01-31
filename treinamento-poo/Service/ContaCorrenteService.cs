using System;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    /// <summary>
    /// Nesta classe vamos manter todas as regras de negócio da nossa pequena aplicação
    /// </summary>
    public class ContaCorrenteService
    {
        ContaCorrente conta1 = new ContaCorrente()
            {
                Titular = "Julio Cesar",
                Agencia = 102,
                Numero = 25555,
                Saldo = 500.52
            };
            /*
            Console.WriteLine($" ------- Dados da Conta Corrente -------");
            Console.WriteLine($"Titular: {conta1.Titular}");
            Console.WriteLine($"Agência: {conta1.Agencia}");
            Console.WriteLine($"Numero: {conta1.Numero}");
            Console.WriteLine($"Saldo: {conta1.Saldo}");
            Console.WriteLine($"------------------------------------------");
            */
        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");
            var valor = double.Parse(Console.ReadLine());
            // implemente a ação sacar aqui e exiba as informações para o usuário...
            Sacar(valor,conta1.Saldo);
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");
            var valor = double.Parse(Console.ReadLine());
            // implemente a ação depositar aqui e exiba as informações para o usuário...
            Depositar(valor,conta1.Saldo);
        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");

            // implemente a ação transferir aqui e exiba as informações para o usuário
        }

        // criar os métodos Sacar, Depositar e Transferir como private
        private void Sacar( double valor, double saldo )
        {
           if(valor>saldo)
           {
               Console.WriteLine("Não foi possível concluir a transação. Seu saldo é inferior ao valor do saque!");
           }
           else{
               saldo=saldo-valor;
               Console.WriteLine("Operação realizada com sucesso!\n");
               Console.WriteLine($"Novo saldo: {saldo.ToString("C")}\n");
           }

        }
        private void Depositar( double valor, double saldo )
        {
               saldo=saldo+valor;
               Console.WriteLine("Operação realizada com sucesso!\n");
               Console.WriteLine($"Novo saldo: {saldo.ToString("C")}\n");

        }

    }
}
