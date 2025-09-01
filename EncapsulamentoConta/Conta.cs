using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta //namespace é uma pasta
{
    public class Conta //tipo de dados meu de programador
    {
        //declaração dos atributos
        private int numero;
        private string? titular;
        private double saldo;

        //declaração dos métodos

        public int Numero{
            get{
                return numero;
            }
            set{
                if(value > 0)
                {
                numero = value;
                } else {
                    System.Console.WriteLine("Número inválido!");
                }
            }
        }

        public string Titular{
            get{
                return titular;
            }
            set{
                titular = value;
            }
        }

        public double Saldo{
            get{
                return saldo;
            }
            set{
                saldo = value;
            }
        }


        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }

        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero +
            "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
    
    }
}