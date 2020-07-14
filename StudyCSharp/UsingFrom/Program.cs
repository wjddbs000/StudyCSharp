using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFrom
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 9, 2, 4, 5, 3, 7, 8, 1, 10 };
            //var result = from n in numbers
            //             where n % 2 == 0
            //             orderby n descending
            //             select n;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            List<Profile> profiles = new List<Profile>
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };
            var newProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Name
                              select new
                              {
                                  Name = item.Name,
                                  InchHeight = item.Height * 0.393
                              };
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name},{item.InchHeight} inch");
            }
        }
    }
}
