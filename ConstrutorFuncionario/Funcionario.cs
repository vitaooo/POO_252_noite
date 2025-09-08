using System;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }

        public void MostrarAtributos(){
            System.Console.WriteLine("Código: " + Codigo + "\tNome" + Nome + "\tSalário: " + Salario);
        }

        public Funcionario(int codigo){
            Codigo = codigo;
        }

        public Funcionario(int codigo, string nome){
            Codigo = codigo;
            Nome = nome;
        }

        public Funcionario(int codigo, string nome, double salario){
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
    }
}