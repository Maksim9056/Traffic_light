using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class TrafficLighS : Colors
    {
        static public TrafficLighS.Color Red =Color.Red;
        static public TrafficLighS.Color Yellow = Color.Yellow;
        static public TrafficLighS.Color Green = Color.Green;
      


        public void voidTrafficLighS()
        {
             Console.WriteLine("Добавлять нам  Red ?");
            Console.WriteLine("Да или Нет");
            string d = Console.ReadLine();
            if (d == "Да")
            {
                Red = Color.Red;
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("Добавлять нам свет светофора Yellow ?");
            Console.WriteLine("Да или Нет");
            d = Console.ReadLine();
            if (d == "Да")
            {
                Yellow = Color.Yellow;

            }
            else {
           Console.WriteLine();
             }
            Console.WriteLine("Добавлять нам свет светофора Green ?");
            Console.WriteLine("Да или Нет");
            d = Console.ReadLine();
            if (d == "Да")
            {
                Green = Color.Green;
                Console.Clear();
                Console.Clear();
            }
            else { Console.WriteLine(); }
        }
    }
}
