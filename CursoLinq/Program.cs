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
        }
    }
}
