// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.CompilerServices;
// using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Pessoa
    {
        private string nome = "";
        private string cpf = "";
        private string telefone = "";

        public Pessoa(string nome, String cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public void CriarPessoa()
        {
            Console.Clear();
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu cpf:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite seu telefone:");
            string telefone = Console.ReadLine();

             Console.Clear();
            Console.WriteLine("Obrigada por se cadastrar");
        }
    }
}