using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome) 
        {
            Nome = nome;
        }

        public virtual void Saudacao() 
        {
            Console.WriteLine($"Olá, {Nome}");
        }
    }
}
