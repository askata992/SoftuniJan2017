﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (num = 1; num <= n; num = (num * 2) + 1)
            {
                Console.WriteLine(num);
            }

            while (num <= n)
            {
                Console.WriteLine(num);

                num = (num * 2) + 1;

            }
        }
    }
}
