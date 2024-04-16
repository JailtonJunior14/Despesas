using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp, desc;
            double contV = 0;
            do
            {
                Console.WriteLine("Descrição das despesas");
                desc = Console.ReadLine();
                Console.WriteLine("Valor: ");
                contV = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de pessoas na casa: ");
                int numP = int.Parse(Console.ReadLine());
                Console.WriteLine("Despesa em: " + desc);
                Console.WriteLine("Depesa total: " + (contV).ToString("C"));
                Console.WriteLine("Media de gasto por pessoa: " + (contV) / numP);
                Console.WriteLine("Deseja cadastrar uma nova despesa? S/N ");
                resp = Console.ReadLine().ToLower();

            }
            while (resp == "s");
            Console.ReadKey();
        }
    }
}
