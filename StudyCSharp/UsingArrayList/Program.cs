using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                int iresult = list.Add(i);
                Console.WriteLine($"{iresult}번째에 데이터 {i}추가 완료");
            }
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            
            list.Remove(2);
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            
            list.Insert(4, 4.5);
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            
            list.Clear();
            Console.WriteLine("After Clear()");
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
