﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BardievaGA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
            public static int Addition(int a, int b)
            {
                return a + b;
            }
            public static int Substract(int a, int b)
            {
                return a - b;
            }
            public static int Mplicate(int a, int b)
            {
                return a * b;
            }
            public static double division(int a, int b)
            {
                if (b == 0)
            {
                Console.WriteLine("Деление на 0 не определено", b);
                return -1;
            }
                else
            {
                return a / b;
            }
            }
        }
}
