using System;

namespace Overloading
{
    class MainApp
    {
        /// <summary>
        /// 덧셈 int형 두 수를 더한다
        /// </summary>
        /// <param name="a">int a</param>
        /// <param name="b">int b</param>
        /// <returns>double type</returns>
        static int Plus(int a, int b)
        {
            return a + b;
        }
        
        /// <summary>
        /// 덧셈 double형 두 수를 더한다
        /// </summary>
        /// <param name="a">double a</param>
        /// <param name="b">double b</param>
        /// <returns>double type</returns>
        static double Plus(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// 더셈 double형 세 수를 더한다
        /// </summary>
        /// <param name="a">double a</param>
        /// <param name="b">double b</param>
        /// <param name="c">double c</param>
        /// <returns></returns>
        static double Plus(double a, double b,double c)
        {
            return a + b + c;
        }
        static int Sum(params int[] args)
        {
            int result = 0;
            foreach (var item in args)
            {
                result += item;
            }
            return result;

        }
        static void MyMethod(string arg1 = "", string arg2 = "")
        {
            Console.WriteLine("MyMethod A");
        }
        static void MyMethod()
        {
            Console.WriteLine("MyMethod B");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Plus(3.14f,2.56f));
            //Console.WriteLine(Plus(1,2,3));
            //int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            //Console.WriteLine($"Sum : {sum}");
            MyMethod("are", "you");
            MyMethod();
        }
    }
}
