using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterface
{
    interface INameValue
    {
        string Name { get; set; }
        string Value { get; set; }
        string GetOtherValue();
    }

    class NameValue : INameValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string GetOtherValue()
        {
            return Value;
        }
    }

    abstract class Product
    {
        private static int Serial = 0;
        public string SerialID
        {
            get { return String.Format($"{Serial++:d5}"); }
        }
        abstract public DateTime ProductDate { get; set; }
    }

    class Myproduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue
            {
                Name = "이름",
                Value = "송정윤"
            };
            NameValue height = new NameValue
            {
                Name = "키",
                Value = "179"
            };
            NameValue weight = new NameValue
            {
                Name = "몸무게",
                Value = "77"
            };
        }
    }
}
