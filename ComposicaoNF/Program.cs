using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComposicaoNF;

namespace ComposicaoNF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ItemNotaFiscal it1 = new ItemNotaFiscal(12);
            ItemNotaFiscal it2 = new ItemNotaFiscal(20);

            NotaFiscal nf = new NotaFiscal(1, "22/09/2025");
            nf.VetItens.Add(it1);
            nf.VetItens.Add(it2);
            System.Console.WriteLine("\nApresentação dos itens de nota fiscal\n");

            foreach (var item in nf.VetItens) // sem chaves pois só tem uma linha nesse bloco
                item.Mostrar();
            // forçar a destruição do objeto
            nf = null; // aqui a variável PERDE a referência de memória 
                       // ficando disponível para o coletor de lixo liberar a memória
                       // chame o Coletor de lixo
            GC.Collect(); // método ESTÁTICO.
        }
    }
}