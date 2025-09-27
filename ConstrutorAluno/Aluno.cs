using System;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private long Ra {get; set;}
        private string Nome {get; set;}
        private static long Contador {get; set;}

        static Aluno(){
            Contador = 0;
        }

        public Aluno() {
            Aluno.Contador++;
            this.Ra = Aluno.Contador;
            this.Nome = "Primeiro Aluno";
        }

        public Aluno(string nome){
            Aluno.Contador++;
            this.Ra = Aluno.Contador;
            this.Nome = nome;
        }

        public void MostrarAtributos() {
            Console.WriteLine(Ra + " - " + Nome);
        }

    }
}
