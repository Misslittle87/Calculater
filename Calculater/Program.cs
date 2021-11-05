using System;
using System.Collections.Generic;


namespace Calculater
{
    class Program
    {
        static void QuitToMenu()
        {
            // Detta tycker jag är ett snyggt sätt att avsluta en skärm.
            // Jag använder Console.Clear för att rensa varje val, och 
            // lagt in en QuitToMenu så att man får en tom consol.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tFör att komma tillbaka till menyn, tryck på enter");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Main(string[] args)
        {
            // Här har jag skapat en lista med stringvektor.
            List<string[]> myCalculater = new List<string[]> { };
            // Här har jag skapat min bool som kontrollerar loopen.
            bool myBool = true;
            // Här börjar min while-loop.
            while (myBool)
            {
                Console.Clear();
                Console.WriteLine("\n\tHej och välkommen till miniräknaren!");
                Console.WriteLine("\n\tVänligen välj en operator.");
                Console.WriteLine("\n\t================================");
                Console.WriteLine("\n\t[1] - Addition");                
                Console.WriteLine("\t[2] - Subtraktion");
                Console.WriteLine("\t[3] - Multiplikation");
                Console.WriteLine("\t[4] - Divition");
                Console.WriteLine("\t[5] - Visa mina sparade uträkningar");
                Console.WriteLine("\t[6] - Avsluta");

                if (Int32.TryParse(Console.ReadLine(), out int userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            string[] plus = new string[3];
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (Int32.TryParse(Console.ReadLine(), out int number1))
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (Int32.TryParse(Console.ReadLine(), out int number2))
                                {                                    
                                    Console.WriteLine($"\n\tResultat: {number1} + {number2} = " + Int32.TryParse(Console.ReadLine(), out int resault1));
                                    myCalculater.Add(resault1);
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\tDu har nog aldrig räknat förr...");
                            }
                            QuitToMenu();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (Int32.TryParse(Console.ReadLine(), out int number3))
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (Int32.TryParse(Console.ReadLine(), out int number4))
                                {
                                    Console.WriteLine($"\n\tResultat: {number3} - {number4} = " + (number3 - number4));
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\tNope... Nope... Nope...");
                            }
                            QuitToMenu();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (Int32.TryParse(Console.ReadLine(), out int number5))
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (Int32.TryParse(Console.ReadLine(), out int number6))
                                {
                                    Console.WriteLine($"\n\tResultat: {number5} * {number6} = " + (number5 * number6));
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\tWTF?!?!");
                            }
                            QuitToMenu();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (Int32.TryParse(Console.ReadLine(), out int number7))
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (Int32.TryParse(Console.ReadLine(), out int number8))
                                {
                                    if (number8 == 0)
                                    {
                                        Console.WriteLine("\n\tDet där går ju inte att dela med...");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n\tResultat: {number7} / {number8} = " + (number7 / number8));
                                    }                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\tVad ska det här föreställa?");
                            }
                            QuitToMenu();
                            break;
                        case 5:
                            if (myCalculater.Count <= 0)
                            {
                                Console.WriteLine("Du har inga sparade uträkningar!");
                            }
                            else if (myCalculater > 0)
                            {
                                Console.WriteLine("\nMina sparade inlägg: ");
                                // Denna loopen räknar upp alla sparade numbers i myCla
                                foreach (string[] number in myCalculater)
                                {
                                    // Här skrivs alla blogginlägg ut med datum[0], titel[1] och inlägg[2]
                                    Console.WriteLine(number[0] + "\n" + number[1] + "\n" + number[2]);
                                }
                            }
                            break;
                        case 6:
                            Console.WriteLine("\n\tTack för du använde miniräknaren!");
                            Console.WriteLine("\n\tHa en bra dag!");
                            myBool = false;
                            break;
                        default:
                            Console.WriteLine("\n\tSådär kan du ju inte skriva!");
                            Console.WriteLine("\n\tDu måste välja mellan menyval 1-5!");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n\tDet där var väl ändå inte rätt!");
                    Console.ReadLine();
                }
            }
        }
    }
}
