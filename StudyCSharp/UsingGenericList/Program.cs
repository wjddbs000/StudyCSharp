﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    intList.Add(i);
            //}
            //foreach (var item in intList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine();

            //intList.RemoveAt(2);
            //intList.Insert(3, 45);

            //foreach (var item in intList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine();

            //Queue<double> queue = new Queue<double>();

            //queue.Enqueue(11.1);
            //queue.Enqueue(22.2);
            //queue.Enqueue(33.3);
            //queue.Enqueue(44.4);

            //while (queue.Count > 0)
            //    Console.WriteLine(queue.Dequeue());

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["하나"] = 100;
            dic["둘"] = 200;
            dic["셋"] = 3;
            dic["넷"] = 4;
            foreach (var item in dic)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
