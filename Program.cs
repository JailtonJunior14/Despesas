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
            double contV = 0, total;
            Console.WriteLine("Descrição das despesas");
            desc = Console.ReadLine();
            do
            {
                Console.WriteLine("Valor: ");
                contV = double.Parse(Console.ReadLine());
                total = contV + contV;
                Console.WriteLine("Deseja continuar?");
                resp = Console.ReadLine().ToLower();

            }
            while (resp == "s");
            Console.WriteLine("Numero de pessoas na casa: ");
            int numP = int.Parse(Console.ReadLine());
            Console.WriteLine("Despesa em: " + desc);
            Console.WriteLine("Depesa total: " + (total).ToString("C"));
            Console.WriteLine("Media de gasto por pessoa: " +  (total)/numP);
            Console.WriteLine("Deseja cadastrar uma nova despesa? S/N ");
             resp = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
