using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace BasicClass
{
    class Cat
    {
        public string Name;
        public Color color;

        public Cat()
        {
            Name = "";
            color = Color.Transparent;
        }
        /// <summary>
        /// 파라미터 생성자
        /// </summary>
        /// <param name="name">고양이 이름</param>
        /// <param name="color">고양이 털색</param>
        public Cat(string name, Color color)
        {
            Name = name;
            this.color = color;
        }
        
        public void Meow()
        {
            Console.WriteLine($"{Name}, 야옹 ~!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat();
            Kitty.Name = "키티";
            Kitty.color = Color.White;
            Kitty.Meow();
            Console.WriteLine($"{Kitty.Name} : {Kitty.color}");

            Cat nero = new Cat("네로", Color.Black);
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.color}");
        }
    }
}
