using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    internal class Item
    {
        string nome { get; set; }
        int quantidade { get; set; }


        public Item(string nome, int quantidade)
        {
            this.nome = "Caneta Azul";
            this.quantidade = quantidade;
        }

        public void retirarItem(int num)
        {
            if (num < 0)
            {
                throw new Exception("Valor inserido menor que 0!");
            }
            else if (num > quantidade)
            {
                throw new Exception("Valor inserido é maior do que é possivel retirar!");
            }
            quantidade -= num;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Item: {nome}\nQuantidade: {quantidade}");
        }
    }
}
