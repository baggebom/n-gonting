using System;

namespace någonting
{

    class Program
    {

        static void Main(string[]args)
        {

            Console.WriteLine("Vilken stad är störst i Sverige?");
            while (true)
            {
                string gissning = Console.ReadLine();

                if (gissning == "Stockholm" || gissning == "stockholm")
                {
                    Console.WriteLine("Korrekt!");
                    break;
                }
                else
                {
                    Console.WriteLine("Försök igen.");

                }
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vilken stad är störst i Norge?");
            while (true)
            {
                string gissning = Console.ReadLine();

                if (gissning == "Oslo" || gissning== "oslo")
                {
                    Console.WriteLine("Korrekt!");

                    break;
                    

                    
                }
                else
                {
                 Console.WriteLine("Försök igen!");

                   
                    
                 

                }

                
            }
            Console.ReadKey();

        }
    }
}