using EncapsulamentoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.Codigo = 1;
        f1.Nome = "João";
        f1.Salario = 2000;

        System.Console.WriteLine(f1.Codigo + " " + f1.Nome + " " + f1.Salario);

    }
}