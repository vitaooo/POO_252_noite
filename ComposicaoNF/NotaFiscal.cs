using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNF
{
    public class NotaFiscal {
        public int NumeroNF { get; set;}
        public string? Data { get; set; }
        public List<ItemNotaFiscal> VetItens {get; set;}

        public NotaFiscal(int nf, string data)
        { // inicializa os atributos da classe
            // No momento da instância do objeto-todo que é a NotaFiscal,
            // a instância da relação/associação DEVE ser realizada/estabelecida
            VetItens = new List<ItemNotaFiscal>();
            NumeroNF = nf;
            Data = data;
        }

        ~NotaFiscal() // o destrutor retirará a referência de memória do vetor instanciado.
        {
            VetItens = null;
            System.Console.WriteLine("Destruindo a nota fiscal!");
        }
    }   
}