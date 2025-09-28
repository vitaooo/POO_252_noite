namespace AgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;

        public Vendedor()
        {
            this.comissao = 0;
        }

        public double Comissao
        {
            get { return comissao; }
        }

        public void AdicionarComissao(double precoProduto)
        {
            this.comissao += precoProduto * 0.02;
        }

        public string MostrarAtributo()
        {
            return $"Comissão do Vendedor: {this.Comissao:C}";
        }
    }
}