using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCasting
{
    class Program
    {
        class Mammal // 포유류
        {
            public void Nurse()
            {
                Console.WriteLine("Nurse()");
            }
        }
        class Dog : Mammal
        {
            public void Bark()
            {
                Console.WriteLine("Bark()");
            }
        }
        static void Main(string[] args)
        {
                Mammal mammal = new Dog();
                Dog dog;
                if(mammal is Dog)
                {
                    dog = mammal as Dog;
                    dog.Bark();
                }
        }
    }
}
