using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumberConverion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            string b = a.ToString();
            Console.WriteLine($"b={b}");
            float c = 3.141592f;
            string d = c.ToString();
            Console.WriteLine($"d={d}");

            string e = "123456*";
            int f;
            bool result = int.TryParse(e,out f);
            Console.WriteLine($"result={result}");
            Console.WriteLine($"f={f}");
            string g = "3.141592";
            float h = float.Parse(g);
            Console.WriteLine($"h={h}");
        }
    }
}
