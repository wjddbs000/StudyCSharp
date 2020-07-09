using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temp;
        public void SetTemp(int temp)
        {
            if(temp<-5 || temp > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temp = temp;
        }
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temp}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemp(20);
                heater.TurnOnWater();

                heater.SetTemp(-2);
                heater.TurnOnWater();

                heater.SetTemp(50);
                heater.TurnOnWater();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
