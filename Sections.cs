using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Sections :TrafficLighS
    {   //Active Disable (Горит или Не_Горит)
        static public Sections.Color Section1{ get; set; }
        static public Sections.Color Section2 { get; set; }
        static public Sections.Color Section3{ get;set; }
        public Color ColorSection { get;set;}
        public Sections.Color State_StateSection { get; set; } 
 public Sections Active_Disable { get; set; }
        //enum Active_Disable
        //{
        //    Горит, Не_Горит
        //};

        public void voidSection()
        {
            Console.WriteLine();
            Console.WriteLine("Выбери  свет Section1  ?");
            Console.WriteLine(" Red ");
            Console.WriteLine(" Yellow ");
            Console.WriteLine(" Green ");
            string f = Console.ReadLine();
            switch (f)
            {
                case "Red":
                    Section1 = Color.Red;
                    Console.WriteLine($"Выбран цвет Section1: {Section1} ");
                    break;
                case "Yellow":
                    Section1 = Color.Yellow;
                    Console.WriteLine($"Выбран цвет Section1:{Section1} ");
                    break;
                case "Green":
                    Section1 = Color.Green;
                    Console.WriteLine($"Выбран цвет Section1:{Section1} ");
                    break;
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Выбери  свет Section2  ?");
            Console.WriteLine(" Red ");
            Console.WriteLine(" Yellow ");
            Console.WriteLine(" Green ");
            f = Console.ReadLine();
            switch (f)
            {
                case "Red":
                    Section2 = Color.Red;
                    Console.WriteLine($"Выбран цвет Section2: {Section2} ");
                    break;
                case "Yellow":
                    Section2 = Color.Yellow;
                    Console.WriteLine($"Выбран цвет Section2: {Section2} ");
                    break;
                case "Green":
                    Section2 = Color.Green;
                    Console.WriteLine($"Выбран цвет Section2: {Section2} ");
                    break;
            }
            Console.Clear();
            Console.WriteLine("Выбери  свет Section3  ?");
            Console.WriteLine(" Red ");
            Console.WriteLine(" Yellow ");
            Console.WriteLine(" Green ");
            Console.WriteLine();
            f = Console.ReadLine();
            switch (f)
            {
                case "Red":
                    Section3 = Color.Red;
                    Console.WriteLine($"Выбран цвет Section3: {Section3} ");
                    break;
                case "Yellow":
                    Section3 = Color.Yellow;
                    Console.WriteLine($"Выбран цвет Section3: {Section3} ");
                    break;
                case "Green":
                    Section3 = Color.Green;
                    Console.WriteLine($"Выбран цвет Section3: {Section3} ");
                    break;
                    Console.Clear();
            }
             











        Console.Clear();
        }
     }
}

