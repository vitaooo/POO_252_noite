using vetorProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto[] produtos = new Conta[6];

        for (int i = 0; i < produtos.Length; i++)
        {

            produtos[i] = new Conta();
            Console.Write("Digite o código produto: ");
            produtos[i].Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Nome do produto: ");
            produtos[i].titular = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            produtos[i].saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o estoque do produto: ");
            produtos[i].saldo = Convert.ToInt32(Console.ReadLine());
        }
        produtos[1].MostrarAtributos();
    }
}