using System;
using System.Collections.Generic;

namespace ComposicaoBanco
{
    public class Banco
    {
        
        private List<Poupanca> poups;
        private List<ContaCorrente> contas;

        public Banco()
        {
            Console.WriteLine("Banco sendo criado...");
            IniciarBanco();
        }

        ~Banco()
        {
            Console.WriteLine("-> Destrutor: O Banco faliu e todas as contas foram perdidas.");
        }

        public void IniciarBanco()
        {
            this.poups = new List<Poupanca>();
            this.contas = new List<ContaCorrente>();
        }

        public void AbrirConta(int numero, double saldoInicial, double chequeEspecial)
        {
            ContaCorrente novaConta = new ContaCorrente(numero, saldoInicial, chequeEspecial);
            this.contas.Add(novaConta);
        }

        public void AbrirPoupanca(int numero, double saldoInicial)
        {
            Poupanca novaPoupanca = new Poupanca(numero, saldoInicial);
            this.poups.Add(novaPoupanca);
        }
        public void DecretarFalencia()
        {
            Console.WriteLine("\n!!! ATENÇÃO: O banco decretou falência !!!");
            this.contas.Clear();
            this.poups.Clear();
        }
    }
}