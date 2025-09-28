using System;

namespace ComposicaoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Iniciando Simulação Bancária ---\n");

            Banco meuBanco = new Banco();

            Console.WriteLine("\n--- Abrindo Contas ---\n");
            
            meuBanco.AbrirPoupanca(101, 500.00);
            meuBanco.AbrirConta(201, 1000.00, 200.00);

            meuBanco.DecretarFalencia();

            Console.WriteLine("\n--- Fim da Simulação ---");
            Console.WriteLine("O objeto 'meuBanco' ainda existe, mas suas listas de contas estão vazias.");
            Console.WriteLine("Quando o programa terminar, o Garbage Collector irá destruir o objeto 'meuBanco'.");
            Console.WriteLine("Como as contas não têm mais referência, elas também serão destruídas.");
            
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}