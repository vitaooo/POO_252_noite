using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vetorProduto
{
    public class Produto
    {
        private int codigo;
        private string nome = "";
        private float preco;
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

        public double SubTotal
        {
            get { return subTotal; }
        }


        public void MostrarAtributos()
        {
            System.Console.WriteLine("\n--------------");
            System.Console.WriteLine("Código: " + codigo);
            System.Console.WriteLine("Nome: " + nome);
            System.Console.WriteLine("Preço: RS" + preco.ToString("F2"));
            System.Console.WriteLine("Estoque: " + estoque);
            System.Console.WriteLine("-----------------");
        }

        public void CalcularAumento(double p)
        {
            preco = (float)(preco + (preco * (p / 100)));
            System.Console.WriteLine("O novo preço após o aumento é: " + Preco);
        }

        public void RetirarEstoque(int qtde)
        {
            if(qtde <= estoque){
                estoque = estoque - qtde;
            } else {
                System.Console.WriteLine($"Erro: Estoque insuficiente para o produto: '{nome}'. Disponível: {estoque}, tentativa de retirada: {qtde}.");
            }
        }

        public void CalcularSubTotal()
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            subTotal = preco * estoque;
            Console.WriteLine("Preço: " + preco.ToString("F2"));
            Console.WriteLine("Quantidade em Estoque: " + estoque);
            Console.WriteLine("Subtotal: " + subTotal.ToString("F2"));
        }


    }
}