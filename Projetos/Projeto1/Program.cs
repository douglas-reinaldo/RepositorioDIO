using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item canetaAzul = new Item("Caneta Azul", 50);
            canetaAzul.retirarItem(60);
            canetaAzul.ExibirDados();
        }
    }
}
