﻿using System;
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
            int i = 1;
            do
            {
                if (i % 3 == 0)
                {        
                Console.WriteLine("Divisor de Daniel Fernando: " + i);
                }
                i++;
            } while (i <= 1000);
            Console.ReadKey();
        }
    }
}
