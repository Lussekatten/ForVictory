using System;

namespace Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slump();
            CalculateValues();
        }

        static void Slump()
        {
            Random rnd = new Random();
            int slumptal;
            int tal;

            slumptal = (rnd.Next(1, 101));

            Console.Write("Skriv ett tal ");
            tal = int.Parse(Console.ReadLine());
            int antal_ggr = 1;

            while (tal != slumptal)
            {
               
                antal_ggr++;
                Console.Write("Fel, försök igen och skriv ett tal: ");
                tal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Rätt tal! " + slumptal);
            Console.WriteLine("Antal gissningar =  " + antal_ggr);

        }

        static void CalculateValues()
        {
          
            double userInput;

            Console.Write("Skriv ett flyttal: ");
            userInput = double.Parse(Console.ReadLine());

            double atPowerOfTwo = Math.Pow(userInput,2);
            double squareRoot = Math.Sqrt(userInput);
            double atPowerOfTen = Math.Pow(userInput, 10);

            Console.WriteLine("Talet upphöjt till 2 blir lika med: {0}", atPowerOfTwo.ToString());
            Console.WriteLine("Roten ur {0} blir lika med {1}", userInput, squareRoot.ToString());
            Console.WriteLine("Talet upphöjt till 2 blir lika med: {0}", atPowerOfTen.ToString());

        }
    }
}
