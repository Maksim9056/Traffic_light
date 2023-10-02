using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Xml.Schema;
using System.Security.Policy;
using System.Runtime.ConstrainedExecution;
using ConsoleApp18;
using System.Windows;
using static System.Collections.Specialized.BitVector32;
using System.ComponentModel;
using static ConsoleApp18.Colors;
using static ConsoleApp18.TrafficLighS;
using static ConsoleApp18.Sections;
using static ConsoleApp18.Arrows;
namespace ConsoleApp18
{
    internal class Program : Arrows
    {
        public enum Секция
        {
            Горит,
            Негорит
        };

        static void Main(string[] args)
        {
            var d = new TrafficLighS();
            var b = new Sections();
            var c = new Arrows();
            var f = new Program();
            var G = new SectionGroup();
            d.voidTrafficLighS();
            b.voidSection();
            c.voidArrow();
            G.voidSectionGroup();
            Console.Clear();
            c.Status();
            G.State();
            string D;
            Console.WriteLine("Попробовать еще раз тек");
            Console.WriteLine(" ДА ");
            Console.WriteLine(" НЕТ ");
            D = Console.ReadLine();
            if (D == "ДА")
            {
                Console.Clear();
                d.voidTrafficLighS();
                b.voidSection();
                c.voidArrow();
                Console.WriteLine("Попробовать еще раз тек");
                Console.WriteLine(" ДА ");
                Console.WriteLine(" НЕТ ");
                D = Console.ReadLine();
                if (D == "ДА")
                    d.voidTrafficLighS();
                b.voidSection();
                c.voidArrow();
                D = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("До свидания !");
            }
            Console.ReadLine();
        }
    }
}
         
    
