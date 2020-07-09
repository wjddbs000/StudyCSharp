using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }
    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Luncher Armed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArmorSuite armor = new ArmorSuite();
            armor.Initialize();
            ArmorSuite ironMan = new IronMan();
            ironMan.Initialize();
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}
