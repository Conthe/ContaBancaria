using System;

namespace CriacaoContaBancaria
{
    class CriacaoConta
    {
        static void Main(string[] args)
        {
            string numeroConta, titular, depositoInicial;
            ContaBancaria NovaConta;

            InfoConta(out numeroConta, out titular, out depositoInicial);
            CriarConta(numeroConta, titular, out depositoInicial, out NovaConta);

            NovaConta.MostrarDadosConta();

            NovaConta.Depositar();

            NovaConta.MostrarDadosConta();

            NovaConta.Sacar();

            NovaConta.MostrarDadosConta();
        }

        private static void CriarConta(string numeroConta, string titular, out string depositoInicial, out ContaBancaria NovaConta)
        {
            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoInicial = Console.ReadLine();
            if (depositoInicial == "s")
            {
                Console.Write("Entre o valor  de depósito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                NovaConta = new ContaBancaria(numeroConta, titular, saldoInicial);
            }
            else
            {
                NovaConta = new ContaBancaria(numeroConta, titular);
            }
        }

        private static void InfoConta(out string numeroConta, out string titular, out string depositoInicial)
        {
            numeroConta = string.Empty;
            titular = string.Empty;
            depositoInicial = string.Empty;
            Console.Write("Entre o número da conta: ");
            numeroConta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();
        }
    }
}
