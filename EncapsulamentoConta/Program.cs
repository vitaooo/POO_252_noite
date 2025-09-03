using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.Numero = 0;
        c1.Titular = "João";
        c1.Saldo = 2000;
        System.Console.WriteLine(c1.Numero + " " + c1.Titular + " " + c1.Saldo);

        Conta c2 = new Conta();
        System.Console.WriteLine("Digite o número do Usuário: ");
        c2.Numero = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o nome do titular: ");
        c2.Titular = Console.ReadLine();
        System.Console.WriteLine("Digite o Saldo");
        c2.Saldo = Convert.ToInt32(Console.ReadLine());
        c2.MostrarAtributos();

    }
}