﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабраб5вар
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.001;
            double x = double.Parse(Console.ReadLine());
            double S = 0;
            int N = 0;
            double A = x;
            do
            {
                S = S + A;
                N += 1;
                A= A*(2/(N+1));
            }
            while (A >= eps);
            Console.WriteLine($"Сумма членов ряда S={S}число итераций N={N}");
        }
    }
    }

