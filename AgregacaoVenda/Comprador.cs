namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;

        public Comprador(double entrada)
        {
            this.verba = entrada;
        }

        public double Verba
        {
            get { return verba; }
        }

        public void RetirarVerba(double valorCompra)
        {
            if (valorCompra <= this.verba)
            {
                this.verba = verba - valorCompra;
                System.Console.WriteLine("Compra efetivada! Saldo restante: " + this.verba);
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente!");
            }
        }

        public string MostrarAtributo()
        {
            return $"Verba do Comprador: {this.Verba:C}";
        }
    }
}