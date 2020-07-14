﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegate
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보통");
            Calculator Calc = new Calculator();
            Console.WriteLine(Calc.Plus(3, 4));
            Console.WriteLine(Calc.Minus(7, 4));

            Console.WriteLine("대리자");
            MyDelegate Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calc.Minus);
            Console.WriteLine(Callback(7, 4));
        }
    }
}
