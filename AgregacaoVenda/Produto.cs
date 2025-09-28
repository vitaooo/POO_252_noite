namespace AgregacaoVenda
{
    public class Produto
    {
        private static int proximoCodigo;
        private int codigo;
        private string nome = string.Empty;
        private double preco;

        static Produto()
        {
            proximoCodigo = 500;
        }

        public Produto(string nome, double preco)
        {
            this.codigo = proximoCodigo++;
            this.Nome = nome;
            this.preco = preco;
        }

        public int Codigo
        {
            get{ return codigo; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value;  }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    System.Console.WriteLine("Informe um valor positivo!");
                    preco = 0;
                }
            }
        }

        public string MostrarAtributos()
        {
            return $"Código: {this.Codigo} Nome: {Nome} Preço: {Preco:C}";
        }
    }
}