using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 12 };

            IEnumerable<int> valores = from n in numeros where n > 3 && n < 8 select n;

            // mostrar los resultados
            foreach (int num in valores)
                Console.WriteLine(num);
            Console.ReadLine();

            Console.WriteLine("-------------------------------");

            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p;
            foreach (string postre in encontrados)
                Console.WriteLine(postre);
            Console.ReadLine();
        }
    }
}
