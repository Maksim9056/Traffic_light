using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp18.Program;
using static ConsoleApp18.Sections;
namespace ConsoleApp18
{
    public class Arrows : Sections
    {
       public static  Sections.Color Direct;
       public  static  Sections.Color ArrowRigt;
       public static  Sections.Color ArrowLeft ;      
        public Color ColorSection { get; set; }
        //public State StateSection { get; set; } 
        //public enum Arrow
        //{
        //    Disable,
        //    Active,

        //};
        public void voidArrow()
        { 
            Console.WriteLine("Выбери Section для Direct  ?");
            Console.WriteLine(" Section1 ");
            Console.WriteLine(" Section2 ");
            Console.WriteLine(" Section3 ");

            string f = Console.ReadLine();
            switch (f)
            {
                case "Section1":
                    {
                        if (Section1 == Color.Red)
                        {
                            Direct = Section1 = Sections.Color.Red;
                            Console.WriteLine($"Выбрана Section1 для Direct: {Direct} ");
                            Console.Clear();
                        }

                        if (Section1 == Color.Yellow)
                        {
                            Direct = Section1 = Sections.Color.Yellow;
                            Console.WriteLine($"Выбрана Section1 для Direct: {Direct} ");
                            Console.Clear();
                        }
                        if (Section1 == Color.Green)
                        {
                            Direct = Section1 = Sections.Color.Green;
                            Console.WriteLine($"Выбрана Section1 для Direct: {Direct} ");
                            Console.Clear();
                        }
                    }
                    break;
                    Console.Clear();
                case "Section2":

                    {
                        if (Section2 == Color.Red)
                        {
                            Direct = Section2 = Sections.Color.Red;
                            Console.WriteLine($"Выбрана Section1 для Direct: {Direct} ");
                            Console.Clear();
                        }

                        if (Section2 == Color.Yellow)
                        {
                            Direct = Section2 = Sections.Color.Yellow;
                            Console.WriteLine($"Выбрана Section1 для Direct: {Direct} ");
                            Console.Clear();
                        }
                        if (Section2 == Color.Green)
                        {
                            Direct = Section2 = Sections.Color.Green;
                            Console.WriteLine($"Выбрана Section2 для Direct: {Direct} ");
                            Console.Clear();
                        }
                    }
                    break; Console.Clear();
                case "Section3":
                    {
                        if (Section3 == Color.Red)
                        {
                            Direct = Section3 = Sections.Color.Red;
                            Console.WriteLine($"Выбрана Section3 для Direct: {Direct} ");
                            Console.Clear();
                        }

                        if (Section3 == Color.Yellow)
                        {
                            Direct = Section3 = Sections.Color.Yellow;
                            Console.WriteLine($"Выбрана Section3 для Direct: {Direct} ");
                            Console.Clear();
                        }
                        if (Section3 == Color.Green)
                        {
                            Direct = Section3 = Sections.Color.Green;
                            Console.WriteLine($"Выбрана Section3 для Direct: {Direct} ");
                            Console.Clear();
                        }
                    }
                    Console.Clear();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Выбери  свет ArrowRigt  ?");
            Console.WriteLine(" Section1 ");
            Console.WriteLine(" Section2 ");
            Console.WriteLine(" Section3 ");
            f = Console.ReadLine();
            switch (f)
            {
                case "Section1":
                    {
                        if (Section1 == Color.Red)
                        {
                            ArrowRigt = Section1 = Sections.Color.Red;
                            Console.WriteLine($"Выбрана Section1 для ArrowRigt: {ArrowRigt} ");
                            Console.Clear();
                        }

                        if (ArrowRigt == Color.Yellow)
                        {
                            ArrowRigt = Section1 = Sections.Color.Yellow;
                            Console.WriteLine($"Выбрана Section1 для ArrowRigt: {ArrowRigt} ");
                            Console.Clear();
                        }
                        if (Section1 == Color.Green)
                        {
                            ArrowRigt = Section1 = Sections.Color.Green;
                            Console.WriteLine($"Выбрана Section1 для ArrowRigt: {ArrowRigt} ");
                            Console.Clear();
                        }
                    }
                    break; Console.Clear();
                case "Section2":
                    {
                        if (Section2 == Color.Red)
                        {
                            ArrowRigt = Section2 = Sections.Color.Red;
                            Console.WriteLine($"Выбрана Section1 для ArrowRigt: {ArrowRigt} ");
                            Console.Clear();
                        }

                        if (Section2 == Color.Yellow)
                        {
                            ArrowRigt = Section2 = Sections.Color.Yellow;
                            Console.WriteLine($"Выбрана Section1 для ArrowRigt: {ArrowRigt} ");
                            Console.Clear();
                        }
                        if (Section2 == Color.Green)
                        {
                            ArrowRigt = Section2 = Sections.Color.Green;
                            Console.WriteLine($"Выбрана Section2 для Direct: {ArrowRigt} ");
                            Console.Clear();
                        }
                    }
                    break;
                    Console.Clear();
                case "Section3":
                    {
                        ArrowRigt = Section3;
                        Console.WriteLine($"Выбрана Section3 ArrowRigt: {ArrowRigt} ");
                        Console.Clear();
                    }
                    Console.Clear();
                    break; 
            }
            Console.Clear();
            Console.WriteLine("Выбери  Section для ArrowLeft ?");
         Console.WriteLine(" Section1 ");
         Console.WriteLine(" Section2 ");
          Console.WriteLine(" Section3 ");
          f = Console.ReadLine();
            switch (f)
           {
             case "Section1":
               {
                        if (Section2 == Color.Red)
                        {
                            ArrowLeft = Section1 = Sections.Color.Red;
                            Console.WriteLine($"Выбрана Section1 для ArrowLeft: {ArrowLeft} ");
                            Console.Clear();
                        }

                        if (Section2 == Color.Yellow)
                        {
                            ArrowLeft = Section1 = Sections.Color.Yellow;
                            Console.WriteLine($"Выбрана Section1 для ArrowLeft: {ArrowLeft} ");
                            Console.Clear();
                        }
                        if (Section2 == Color.Green)
                        {
                            ArrowLeft = Section1 = Sections.Color.Green;
                            Console.WriteLine($"Выбрана Section1 для ArrowLeft: {ArrowLeft} ");
                            Console.Clear();
                        }
                        //ArrowLeft = d.Section1;
                        //        Console.WriteLine($"Выбрана Section1 для ArrowLeft: {ArrowLeft} ");
               }
               break;
             case "Section2":
                    if (Section2 == Color.Red)
                    {
                        ArrowLeft = Section2 = Sections.Color.Red;
                        Console.WriteLine($"Выбрана Section2 для ArrowLeft: {ArrowLeft} ");
                        Console.Clear();
                    }

                    if (Section2 == Color.Yellow)
                    {
                        ArrowLeft = Section2 = Sections.Color.Yellow;
                        Console.WriteLine($"Выбрана Section2 для ArrowLeft: {ArrowLeft} ");
                        Console.Clear();
                    }
                    if (Section2 == Color.Green)
                    {
                        ArrowLeft = Section2 = Sections.Color.Green;
                        Console.WriteLine($"Выбрана Section2 для ArrowLeft: {ArrowLeft} ");
                        Console.Clear();
                    }
               break;
            case "Section3":

                    if (Section3 == Color.Red)
                    {
                        ArrowLeft = Section3 = Sections.Color.Red;
                        Console.WriteLine($"Выбрана Section3 для ArrowLeft: {ArrowLeft} ");
                        Console.Clear();
                    }

                    if (Section3 == Color.Yellow)
                    {
                        ArrowLeft = Section3 = Sections.Color.Yellow;
                        Console.WriteLine($"Выбрана Section3 для ArrowLeft: {ArrowLeft} ");
                        Console.Clear();
                    }
                    if (Section3 == Color.Green)
                    {
                        ArrowLeft = Section3 = Sections.Color.Green;
                        Console.WriteLine($"Выбрана Section3 для ArrowLeft: {ArrowLeft} ");
                        Console.Clear();
                    }
             Console.Clear();
             break;
            }
        }
        public void Status()
        {
            Console.WriteLine();
            if (Section1 == Red)
            {
                Console.WriteLine();
                Console.WriteLine($"Section :Section1:{Секция.Негорит}:Section1:{Section1}");
                if (Section1 == Direct)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section1:Direct:{Direct}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
                if (Section1 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section1:ArrowLeft:{ArrowLeft}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
                if (Section1 == ArrowRigt)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section1:ArrowRigt:{ArrowRigt}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
            }
            else
            {
                Console.WriteLine();
            }
            if (Section1 == Yellow)
            {
                Console.WriteLine();
                Console.WriteLine($"Section :Section1:{Секция.Негорит}:Section1:{Section1}");
                if (Direct == Section1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section1:Direct:{Direct}:{Секция.Негорит}:{Section1}");
                }
                else { Console.WriteLine(); }
                if (Section1 == ArrowLeft)
                {
                    Console.WriteLine($"Section :Section1:ArrowLeft:{ArrowLeft}:{Секция.Негорит}:{Section1}");
                }
                else { Console.WriteLine(); }
                if (Section1 == ArrowRigt)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section1:ArrowRigt:{ArrowRigt}:{Секция.Негорит}:{Section1}");
                }
                else { Console.WriteLine(); }
            }
            else { Console.WriteLine(); }
            if (Section1 == Green)
            {
                Console.WriteLine($"Section :Section1 :{Секция.Горит}:Section1:{Section1}");
                Console.WriteLine();
                if (Section1 == Direct)
                {
                    Console.WriteLine($"Section :Section1:Direct:{Direct}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
                if (Section1 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section1:ArrowLeft:{ArrowLeft}:{Секция.Горит}:{Section1}");
                }
                else { Console.WriteLine(); }
                if (Section1 == ArrowRigt)
                {
                    Console.WriteLine($"Section :Section1:ArrowRigt:{ArrowRigt}:{Секция.Горит}:{Section1}");
                }
                else { Console.WriteLine(); }
            }
            else { Console.WriteLine(); }
            //Section2
            if (Section2 == Red)
            {
                Console.WriteLine($"Section :Section2:{Секция.Негорит}:{Section2}");
                if (Section2 == Direct)
                {
                    Console.WriteLine($"Section :Section2:Direct:{Direct}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
                if (Section2 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:ArrowLeft:{ArrowLeft}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
                if (Section2 == ArrowRigt)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:ArrowRigt:{ArrowRigt}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
            }
            else { Console.WriteLine(); }
            if (Section2 == Yellow)
            {
                Console.WriteLine($"Section :Section2:{Секция.Негорит}:{Section2}");
                if (Section2 == Direct)
                {
                    Console.WriteLine($"Section :Section2:Direct:{Direct}:{Секция.Негорит}");
                }
                else
                {
                    Console.WriteLine();
                }
                if (Section2 == ArrowRigt)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:ArrowRigt:{ArrowRigt}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
                if (Section2 == ArrowLeft)
                {
                    Console.WriteLine($"Section:Section2:ArrowLeft:{ArrowLeft}:{Секция.Негорит}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
            }
            if (Section2 == Green)
            {
                Console.WriteLine($"Section :Section2:{Секция.Горит}:{Section2}");
                if (Section2 == Direct)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:Direct:{Direct}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
                if (Section2 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:ArrowLeft:{ArrowLeft}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
                if (Section2 == ArrowRigt)
                {

                    Console.WriteLine($"Section :Section2:ArrowRigt:{ArrowRigt}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
            }
            else { Console.WriteLine(); }
            //Section3
            if (Section3 == Red)
            {
                Console.WriteLine($"Section :Section3:{Секция.Негорит}:{Section3}");
                if (Section3 == Direct)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section3:Direct:{Direct}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
                if (Section3 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section3:ArrowLeft:{ArrowLeft}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }

                if (Section3 == ArrowRigt)
                {
                    Console.WriteLine($"Section :Section3:ArrowRigt:{ArrowRigt}:{Секция.Негорит}");
                }
                else { Console.WriteLine(); }
            }
            else
            {
                Console.WriteLine();
            }
            if (Section3 == Yellow)
            {
                Console.WriteLine();
                Console.WriteLine($"Section :Section3{Секция.Негорит}:{Section3}");
                if (Section3 == Direct)
                {
                    Console.WriteLine($"Section :Section3:Direct:{Direct}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
                if (Section3 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:ArrowLeft:{ArrowLeft}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
                if (Section3 == ArrowRigt)
                {
                    Console.WriteLine($"Section :Section2:ArrowRigt:{ArrowRigt}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
            }
            else { Console.WriteLine(); }

            Console.WriteLine();

            if (Section3 == Green)
            {

                Console.WriteLine($"Section :Section3:{Секция.Горит}:{Section3}");
                if (Section3 == Direct)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section2:Direct:{Direct}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
                if (Section3 == ArrowLeft)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section3:ArrowLeft:{ArrowLeft}:{Секция.Горит}");
                }
                else
                {
                    Console.WriteLine();
                }
                if (Section3 == ArrowRigt)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Section :Section3:ArrowRigt:{ArrowRigt}:{Секция.Горит}");
                }
                else { Console.WriteLine(); }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
