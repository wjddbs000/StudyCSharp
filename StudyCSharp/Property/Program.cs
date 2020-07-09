using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set {
                if (value.Year >= DateTime.Now.Year)
                {
                    birthday = DateTime.Now;
                }
                else { 
                    birthday = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo()
            {
                Name = "서현",
            Birthday = new DateTime(1991, 6, 28)
        };

            Console.WriteLine($"{info.Name},{info.Birthday}");
            Console.WriteLine($"{info.Age}");

            var myIns = new { Name = "송정윤", Home = "남천" };
            Console.WriteLine($"{myIns.Name},{myIns.Home}");

            var b = new { Subject = "수학", Scores = new int[] { 99, 88, 77 } };
            Console.WriteLine($"{b.Subject}");
            foreach (var item in b.Scores)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
