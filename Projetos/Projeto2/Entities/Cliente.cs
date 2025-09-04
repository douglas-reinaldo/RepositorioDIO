using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Entities
{
    internal class Cliente : Pessoa
    {
        public int NumeroFidelidade { get; set; }
        public Cliente(string nome, int numFidelidade) : base(nome) 
        {
            NumeroFidelidade = numFidelidade;
        }

        public override void Saudacao()
        {
            Console.WriteLine($"Olá, sou {Nome}, cliente número {NumeroFidelidade}.");
        }
    }
}
