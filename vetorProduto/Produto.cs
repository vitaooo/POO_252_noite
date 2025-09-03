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

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo + "Nome: " + nome + " preço: " + preco + "Estoque é: " + estoque);
        }

        public void CalcularAumento(double p)
        {
            this.Preco = Preco + ((p / 100) * Preco);
            System.Console.WriteLine("O novo preço após o aumento é: " + Preco);
        }

        public void CalcularSubtotal()
        {
            float subtotal;

        }

        public void RetirarEstoque(int qtde)
        {
            if (this.Estoque > 1 && qtde == this.Estoque)
            {
                this.Estoque -= qtde;
            }
            else
            {
                System.Console.WriteLine("Não pode retirar mais do que temos no estoque!");
            }
        }


    }
}