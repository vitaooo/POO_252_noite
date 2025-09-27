using System;
using ConstrutorAluno;

public class Program
{
     public static void Main(string[] args) {
            Aluno al1 = new Aluno();
            Aluno al2 = new Aluno("Segundo Aluno");

            al1.MostrarAtributos();
            al2.MostrarAtributos();

    }
}