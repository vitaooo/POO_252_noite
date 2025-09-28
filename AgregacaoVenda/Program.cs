using System;
using System.Collections.Generic;

namespace AgregacaoVenda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            Comprador comprador = new Comprador(1000.00);

            Produto p1 = new Produto("Mouse sem fio", 150.75);
            Produto p2 = new Produto("Teclado Mecânico", 350.00);
            Produto p3 = new Produto("Monitor 24 polegadas", 750.00);

            Console.WriteLine(comprador.MostrarAtributo());
            Console.WriteLine(vendedor.MostrarAtributo());

            List<Produto> carrinho1 = new List<Produto> { p1, p2 };

            Venda venda1 = new Venda(comprador, vendedor, carrinho1);
            venda1.RealizarVenda();
            venda1.MostrarAtributos();

            List<Produto> carrinho2 = new List<Produto> { p3 };
            Venda venda2 = new Venda(comprador, vendedor, carrinho2);
            venda2.RealizarVenda();
            venda2.MostrarAtributos();
        }
    }
}