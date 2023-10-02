using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp18.Program;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp18
{
   public  class SectionGroup: Arrows
    {
      
    
        
        public enum States 
        {  
             Disable,
             Active,
            
        };

        static public Sections.Color  UpperSection{get;set;}
      static public Sections.Color MiddleSection{get;set;}
     static public  Sections.Color LowerSection{get; set;}

        public  void   voidSectionGroup()
        {
            Console.WriteLine("Выбери  свет UpperSection  ?");
            Console.WriteLine(" Red ");
            Console.WriteLine(" Yellow ");
            Console.WriteLine(" Green ");
            string f = Console.ReadLine();
            switch(f) 
            {

                case "Red" :
                    UpperSection = Sections.Color.Red ;
                    break;
                case "Yellow" :
                    UpperSection = Sections.Color.Yellow;
                    break;
                case "Green" :
                    UpperSection = Sections.Color.Green;
                    break;
            }
            Console.WriteLine("Выбери  свет MiddleSection  ?");
            Console.WriteLine(" Red ");
            Console.WriteLine(" Yellow ");
            Console.WriteLine(" Green ");
            f = Console.ReadLine();
            switch (f)
            {

                case "Red"
                     :
                    if (UpperSection == Color.Red)
                    {
                    Console.WriteLine();  
                    }
                    else
                    {
                     MiddleSection = Sections.Color.Red;
                    }
                
                    break;

                case "Yellow" :

                    if (UpperSection == Color.Yellow)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                      MiddleSection = Sections.Color.Yellow;
                    }
                   
                    break;
                case "Green":
                    if (UpperSection == Color.Green)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                      MiddleSection = Sections.Color.Green;
                    }
                    break;
            }
            Console.WriteLine("Выбери  свет LowerSection  ?");
            Console.WriteLine(" Red ");
            Console.WriteLine(" Yellow ");
            Console.WriteLine(" Green ");
            f = Console.ReadLine();
            switch (f)
            {

                case "Red"
                :
                    if (UpperSection == Color.Red)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        LowerSection = Sections.Color.Red;
                    }
              
                    break;
                case "Yellow":
                    if (MiddleSection == Color.Red)
                    {
                        Console.WriteLine();
                    }
                    else {LowerSection = Sections.Color.Yellow;}
         
                    break;
                case "Green":
                    if (UpperSection == Color.Green && MiddleSection == Color.Green)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        LowerSection = Sections.Color.Green;
                    }
                        break;
            }
            Console.WriteLine("Горит UpperSection ?");
         
            }
        public void State()
        {
            if (UpperSection == Sections.Color.Red)
            {
                Console.WriteLine($"SectionGroup :UpperSection:{UpperSection}:{States.Disable}");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine();
            if (UpperSection == Sections.Color.Yellow)
            {

                Console.WriteLine($"SectionGroup :UpperSection:{UpperSection}:{States.Disable}");
            }
            else
            { Console.WriteLine(); }
            if (UpperSection == Sections.Color.Green)
            {

                Console.WriteLine($"SectionGroup :UpperSection:{UpperSection}:{States.Active}");
            }
            else
            { Console.WriteLine(); }

            if (MiddleSection == Sections.Color.Red)
            {
                Console.WriteLine($"SectionGroup :MiddleSection:{MiddleSection}:{States.Disable}");
            }
            else { Console.WriteLine(); }
            if (MiddleSection == Sections.Color.Yellow)
            {

                Console.WriteLine($"SectionGroup :MiddleSection:{MiddleSection}:{States.Disable}");
            }
            else
            { Console.WriteLine(); }
            if (MiddleSection == Sections.Color.Green)
            {

                Console.WriteLine($"SectionGroup :MiddleSection:{MiddleSection}:{States.Active}");
            }
            else
            { Console.WriteLine(); }


            if (LowerSection == Sections.Color.Red)
            {
                Console.WriteLine($"SectionGroup :LowerSection:{LowerSection}:{States.Disable}");
            }
            else { Console.WriteLine(); }
            if (MiddleSection == Sections.Color.Yellow)
            {

                Console.WriteLine($"SectionGroup :LowerSection:{LowerSection}:{States.Disable}");
            }
            else
            { Console.WriteLine(); }
            if (MiddleSection == Sections.Color.Green)
            {

                Console.WriteLine($"SectionGroup :LowerSection:{LowerSection}:{States.Active}");
            }
            else
            { Console.WriteLine(); }
        }
       
    }
}
