using System;
using vetorProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto[] produtos = new Produto[6];

        for (int i = 0; i < produtos.Length; i++)
        {

            produtos[i] = new Produto();

            Console.Write("Digite o código produto: ");

            produtos[i].Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Nome do produto: ");

            produtos[i].Nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");

            produtos[i].Preco = float.Parse(Console.ReadLine());

            Console.Write("Digite o estoque do produto: ");

            produtos[i].Estoque = Convert.ToInt32(Console.ReadLine());
        }

        string op = "";
        while (op != "4")
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 -> Calcular aumento de produtos nos índices pares");
            Console.WriteLine("2 -> Retirar estoque dos produtos nos índices ímpares");
            Console.WriteLine("3 -> Mostrar os produtos");
            Console.WriteLine("4 -> Sair");
            Console.Write("Digite a opção desejada: ");
            op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                System.Console.WriteLine("Digite a porcentagem de aumento dos produtos: ");
                double p = Convert.ToDouble(Console.ReadLine());
                for(int i = 0; i < produtos.Length; i++){
                    if(i % 2 == 0){
                        produtos[i].CalcularAumento(p);
                        System.Console.WriteLine($"O preço do produto {produtos[i].Nome} foi alterado!");
                    }
                }
            } else if(op == "2"){
                System.Console.WriteLine("Quantos produtos quer retirar do estoque? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < produtos.Length; i++){
                    if(i % 2 != 0){
                        produtos[i].RetirarEstoque(quantidade);
                        System.Console.WriteLine($"Estoque alterado do produto {produtos[i].Nome} foi alterado!");
                    }
                }
            } else if(op == "3"){
                System.Console.WriteLine("Lista de produtos");
                for(int i = 0; i < produtos.Length; i++){
                    produtos[i].MostrarAtributos();
                }
            }
        }
    }
}