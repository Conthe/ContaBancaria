using System;
using System.Collections.Generic;
using System.Text;

namespace CriacaoContaBancaria
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string TitularConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public ContaBancaria(string numeroConta, string titularConta, double saldoInicial)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            Saldo = saldoInicial;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + TitularConta + ", Saldo: $" + Saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }

        internal void Depositar()
        {
            Console.Write("Entre um valor para depósito: ");
            double valorParaDeposito = double.Parse(Console.ReadLine());
            Saldo += valorParaDeposito;
        }

        internal void Sacar()
        {
            Console.Write("Entre um valor para saque: ");
            double valorParaSaque = double.Parse(Console.ReadLine());
            valorParaSaque += 5;
            Saldo -= valorParaSaque;
        }

        internal void MostrarDadosConta()
        {
            Console.WriteLine("=======================================");

            Console.WriteLine("Dados da conta");

            Console.WriteLine(this.ToString());

            Console.WriteLine("=======================================");
        }
    }
}
