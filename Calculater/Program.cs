using System;
using System.Collections.Generic;


namespace Calculater
{
    class Program
    {
        static void QuitToMenu()
        {
            // Detta tycker jag är ett snyggt sätt att avsluta en skärm.
            // JAg använder Console.Clear för att rensa varje val, och 
            // lagt in en QuitToMenu så att man får en tom consol.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tFör att komma tillbaka till menyn, tryck på enter");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Main(string[] args)
        {
            // Här har jag skapat en lista med stringvektor.
            List<string[]> myClaculater = new List<string[]> { };
            // Här har jag skapat min bool som kontrollerar loopen.
            bool myBool = true;
            // Här börjar min while-loop.
            while (myBool)
            {
                Console.Clear();
                Console.WriteLine("\n\tHej och välkommen till miniräknaren!");
                Console.WriteLine("\n\t================================");
                Console.WriteLine("\n\tSkriv in ett tal: ");
                int number1;
                Console.WriteLine("\n\tVälj en operator: ");
                Console.WriteLine("\n\tSkriv in ett tal: ");
                int number2;


            }
        }
    }
}
