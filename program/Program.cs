using System.Runtime.CompilerServices;
using System;

namespace program
{
    class Program
    {
        //punkt 1 Klart 
        static void hello32()
        {
           for( int x = 0; x < 32; x++) 
            
            Console.WriteLine("Hello, World");
            Console.ReadLine();
        }
        // Punkt 2, klart ?  
        static int skrivUtKvadrat(int numbval)
        {
             int nvalue = (numbval*numbval);
             return nvalue;
        }
        //Punkt 3
        static  int multi(int numbval, int num2)
        {
         numbval += num2;
         System.Console.WriteLine(numbval);
         Console.ReadLine();
         return numbval;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {

        /*
        //Punkt 1 
             hello32();
            
       //---------------------------------------------------------------------------------------------
        //Punkt 2     
             Console.WriteLine("GE MIG ETT VÄRDE 1-9");
             string värde = Console.ReadLine();

             int numbval;
             bool numbsvar = int.TryParse(värde, out numbval); 
            
                if(numbval > 0 && numbval < 11)
                 {   
                     System.Console.WriteLine("nice dit värde är " + skrivUtKvadrat(numbval)); 
                     Console.ReadLine();
                }  
        //---------------------------------------------------------------------------------------------
        //Punkt 3 
            System.Console.WriteLine("Okej, Ge mig ett nyt tall");
            string num2 = Console.ReadLine();
            float f = float.Parse(num2);


            multi();

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        */


        incapsling princess = new incapsling();

        princess.weight = -900;

        princess.weight = -70;


        Console.WriteLine(princess.Weight);

        /*
        princess.CheckAllStats();
        */

        Console.ReadLine();


        }
    }
}
