using System;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private int numero;
        private double saldo;

        public Poupanca(int numero, double saldoInicial)
        {
            this.numero = numero;
            this.saldo = saldoInicial;
            Console.WriteLine($"Conta Poupança nº {this.numero} criada com saldo de {this.saldo:C}");
        }

        ~Poupanca()
        {
            Console.WriteLine($"-> Destrutor: Conta Poupança nº {this.numero} está sendo encerrada.");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} na Poupança nº {this.numero}. Novo saldo: {this.saldo:C}");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine($"Saldo insuficiente na Poupança nº {this.numero} para sacar {valor:C}.");
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} da Poupança nº {this.numero}. Novo saldo: {this.saldo:C}");
            }
        }

        public void GerarRendimento()
        {
            double rendimento = this.saldo * 0.005;
            this.saldo += rendimento;
            Console.WriteLine($"Rendimento de {rendimento:C} aplicado na Poupança nº {this.numero}. Novo saldo: {this.saldo:C}");
        }
    }
}