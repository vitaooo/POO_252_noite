using EncapsulamentoEstudante;
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante aluno1 = new Estudante();
        aluno1.Nome = "Júlia";
        aluno1.Nota = 8;
        aluno1.ExibirDetalhes();
        aluno1.ExibirInformacoes();

        Estudante aluno2 = new Estudante();
        aluno2.Nome = "Victor";
        aluno2.Nota = 5;
        aluno2.ExibirDetalhes();
        aluno2.ExibirInformacoes();
    
    }
}