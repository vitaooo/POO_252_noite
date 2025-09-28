using System;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private int numero;
        private double saldo;
        private double chequeEspecial;

        public ContaCorrente(int numero, double saldoInicial, double chequeEspecial)
        {
            this.numero = numero;
            this.saldo = saldoInicial;
            this.chequeEspecial = chequeEspecial;
            Console.WriteLine($"Conta Corrente nº {this.numero} criada com saldo de {this.saldo:C} e cheque especial de {this.chequeEspecial:C}");
        }

        ~ContaCorrente()
        {
            Console.WriteLine($"-> Destrutor: Conta Corrente nº {this.numero} está sendo encerrada.");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} na Conta Corrente nº {this.numero}. Novo saldo: {this.saldo:C}");
            }
        }

        public void Sacar(double valor)
        {
            double saldoDisponivel = this.saldo + this.chequeEspecial;
            if (valor > saldoDisponivel)
            {
                Console.WriteLine($"Limite total (saldo + cheque especial) insuficiente na C/C nº {this.numero} para sacar {valor:C}.");
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} da C/C nº {this.numero}. Novo saldo: {this.saldo:C}");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine("\n Extrato Conta Corrente");
            Console.WriteLine($"Conta nº: {this.numero}");
            Console.WriteLine($"Saldo em conta: {this.saldo:C}");
            Console.WriteLine($"Limite Cheque Especial: {this.chequeEspecial:C}");
            Console.WriteLine($"Saldo disponível para saque: {(this.saldo + this.chequeEspecial):C}");
        }
    }
}