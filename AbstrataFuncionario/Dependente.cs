using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependente
{
    public class Dependente : Funcionario
    {
        public int codigo {get; set;}
        public string nome {get; set;}
        public int idade {get; set;}

        public Dependente(int Codigo, string Nome, int Idade){
            codigo = Codigo;
            nome = Nome;
            idade = Idade;
        } 

        public bool verificarMaioridade(codigo){
            if(idade > 18){
                Console.WriteLine("É maior de idade");
                return true;
            } else {
                Console.WriteLine("Não é maior de idade");
                return false;
            }
        }
    }
}
    