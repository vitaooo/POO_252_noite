using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vetorProduto
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        private int estoque;

        private double subTotal;

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }

        public float Preco
        {
            get { return preco; }
            set { this.preco = value; }
        }
        public int Estoque
        {
            get { return estoque; }
            set { this.estoque = value; }
        }

        public int SubTotal
        {
            get { return subTotal; }
        }


        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo);
            System.Console.WriteLine("Nome: " + nome);
            System.Console.WriteLine("Preço: RS" + preco.ToString("F2"));
            System.Console.WriteLine("Estoque: " + estoque);
        }

        public void CalcularAumento(double p)
        {
            preco = preco + (preco * (p / 100));
            System.Console.WriteLine("O novo preço após o aumento é: " + Preco);
        }

        public void RetirarEstoque(int qtde)
        {
            estoque = estoque - qtde;
        }

        public void CalcularSubTotal()
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            subtotal = preco * estoque;
            Console.WriteLine("Preço: " + preco.ToString("F2"));
            Console.WriteLine("Quantidade em Estoque: " + estoque);
            Console.WriteLine("Subtotal: " + subtotal.ToString("F2"));
        }


    }
}