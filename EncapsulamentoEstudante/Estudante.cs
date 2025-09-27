using System;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string nome;
        private int nota;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
                else
                {
                    System.Console.WriteLine("Nome inválido! Não pode ser vazio.");
                }
            }
        }
        public int Nota
        {
            get
            {
                return nota;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota = value;
                }
                else
                {
                    System.Console.WriteLine("Valor da nota incorreto!!");
                }
            }
        }

        public bool EstaAprovado()
        {
            if (Nota >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExibirDetalhes()
        {
            System.Console.WriteLine(Nome + " " + Nota);
        }
    }
}