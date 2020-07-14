using System;

namespace CustomerExeption
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {
        }

        public InvalidArgumentException(string message) : base(message)
        {
        }

        public object Argument
        {
            get;
            set;
        }

        public string Range
        {
            get;
            set;
        }
    }

    class Program
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (var item in args)
            {
                if (item > 255)
                    throw new InvalidArgumentException()
                    {
                        Argument = item,
                        Range = "0~255"
                    };
            }

            return (alpha << 24 & 0xFF000000) |
                   (red << 16 & 0x00FF0000) |
                   (green << 8 & 0x0000FF00) |
                   (blue & 0x000000FF);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"0x{MergeARGB(255, 111, 111, 111):x}");
                Console.WriteLine($"0x{MergeARGB(255, 255, 257, 255):x}");
            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine($"예외발생 : {e.Message}");
                Console.WriteLine("제대로 넣어라");

            }

        }
    }
}
