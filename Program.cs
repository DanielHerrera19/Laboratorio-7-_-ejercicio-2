using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7___ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Divisor de Daniel Fernando: " + i);
                }
            }

            Console.ReadKey();
        }
    }
}