using System;
using System.Collections.Generic;


namespace Calculater
{
    class Program
    {
        static void QuitToMenu()
        {
            /* Detta tycker jag är ett snyggt sätt att avsluta en skärm.
             *Jag använder Console.Clear för att rensa varje val, och 
             *lagt in en QuitToMenu-metod så att man kommer tillbaka till huvudmenyn.
             *Har även lagt till färgen gul på texten för att användaren
             *lätt kan se skillnad.
             */
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tFör att komma tillbaka till menyn, tryck på enter");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        static void Main(string[] args)
        {
            /* Här börjar mainsidan. Allt ovenför är metoder och klasser.
             * Jag har även skapat vektorlistan utanför loopen för annars raderas
             * den när loopen börjar om igen.
             */
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Här har jag skapat en lista med int-vektor.
            List<double[]> myCalculater = new List<double[]> { };
            /* Här har jag skapat min bool (som enbart kan innehålla ett sant 
             * eller falskt värde) som kontrollerar loopen.
             * Sålänge (while) loopen är true (påsåendet är sant) så kommer
             * loopen att fortsätta runt. Tills användaren väljer att 
             * avsluta programmet.
             */
            bool myBool = true;
            /* Här börjar min while-loop.
             * Jag tycker det är enkelt att använda en bool som vilkor
             * då användaren kan välja att stänga av programmet.
             */            
            while (myBool)
            {
                /* Här börjar min meny jag har valt att använda. Och till menyn har jag
                 * valt att använda mig av en switch då den passar bra till just menyval.
                 *\n gör att jag får en ny rad, \t tabbar in raderna ett steg.
                 */
                Console.Clear();
                Console.WriteLine("\n\tHej och välkommen till miniräknaren!");                
                Console.WriteLine("\t====================================");
                Console.WriteLine("\n\t>>> Vänligen välj en operator <<<");
                Console.WriteLine("\n\t[1] - Addition");                
                Console.WriteLine("\t[2] - Subtraktion");
                Console.WriteLine("\t[3] - Multiplikation");
                Console.WriteLine("\t[4] - Divition");
                Console.WriteLine("\t[5] - Visa mina sparade uträkningar");
                Console.WriteLine("\t[6] - Avsluta");
                /* Jag har valt att lägga min switch inom en if-statement som en felhantering.
                 * inom parantesen har jag en annan felhantering om användaren skriver fel
                 * så att programmet inte ska cracha. Userinputen måste också stå inom loopen
                 * då vi inte vill att detta valet ska sparas.
                 * Int32.TryParse(Console.ReadLine(), out int userInput);
                 */
                string userInput = Console.ReadLine(); // Kollar vad användaren skrivit in för menyval         
                if (Int32.TryParse(Console.ReadLine(), out int answer)) //Konverterar userInput till en int
                {
                    /* userInput är vad användaren knappar in från menyn.
                     * Switchen innehåller 6 cases och en default. Jag har använt ett
                     * case för varje räkneoperator.
                     */
                    switch (answer)
                    {
                        case 1:
                            Console.Clear(); // För att rensa skärmen
                            /* Här lägger jag till tre indexplatser i min listvektor
                             * som sedan sparas i minnet. Jag har lagt denna nya lista
                             * innanför loopen för jag vill att den ska raderas varje gång
                             * loopen börjar om. Men själva listan är utanför för att det 
                             * ska kunna sparas i den.
                             */
                            double[] plus = new double[3];
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number1)) // Ytterligare en felhantering
                            {
                                plus[0] = number1; // Lägger till första siffran i min plus-vektorlista
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number2)) // Felhantering
                                {
                                    plus[1] = number2; // Lägger till andra siffran i min plus-vektorlista
                                    double resault1 = number1 + number2; // här initeriar jag resultatet
                                    Console.WriteLine($"\n\tResultat: {number1} + {number2} = " + resault1); //Uträkning
                                    plus[2] = resault1; // Resultatet läggs till i min plus-vektorlista
                                    myCalculater.Add(plus); // Hela min plus-lista sparas i min vektorlista
                                }
                            }
                            else
                            {
                                /* I detta blocket skickar jag felhanteringen om användaren skriver något annat
                                 * än vad programmet vill, annars hade programmet crachat.
                                 */
                                Console.WriteLine("\n\tDu har nog aldrig räknat förr...");
                            }
                            QuitToMenu(); // Metoden som jag gjort
                            break;
                        case 2:
                            Console.Clear();
                            double[] minus = new double[3]; // Vektorlistan för minus
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number3)) //Felhantering
                            {
                                minus[0] = number3; //Lägger till första siffran i min minus-vektorlista                       
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number4)) //Felhantering
                                {
                                    minus[1] = number4; // Lägger till andra siffran i min minus-vektorlista
                                    double resault2 = number3 - number4; // Initierar resultatet
                                    Console.WriteLine($"\n\tResultat: {number3} - {number4} = " + resault2); // Uträkning
                                    minus[2] = resault2; // Lägger till resultatet i minus-vektorlista
                                    myCalculater.Add(minus); // Hela minus-listan sparas i min vektorlista
                                }
                            }
                            else
                            {
                                /* I detta blocket skickar jag felhanteringen om användaren skriver något annat
                                 * än vad programmet vill, annars hade programmet crachat.
                                 */
                                Console.WriteLine("\n\tNope... Nope... Nope...");
                            }
                            QuitToMenu();
                            break;
                        case 3:
                            Console.Clear();
                            double[] multiplikation = new double[3];
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number5))
                            {
                                multiplikation[0] = number5;
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number6))
                                {
                                    multiplikation[1] = number6;
                                    double resault3 = number5 * number6;
                                    Console.WriteLine($"\n\tResultat: {number5} * {number6} = " + resault3);
                                    myCalculater.Add(multiplikation);
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
                            double[] divide = new double[3];
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number7))
                            {
                                divide[0] = number7;
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number8))
                                {
                                    divide[1] = number8;
                                    double resault4 = number7 / number8;
                                    /* I detta if-blocket har jag felhanterat att det inte går att dela med noll,
                                     * annars ska den göra en en uträkning.
                                     */
                                    if (number8 == 0)
                                    {
                                        //Detta händer när man försöker dela med noll
                                        Console.WriteLine("\n\tDet där går ju inte att dela med...");
                                    }
                                    else
                                    {
                                        //Annars görs denna uträkningen
                                        Console.WriteLine($"\n\tResultat: {number7} / {number8} = " + resault4);
                                        myCalculater.Add(divide);
                                    }
                                }
                            }
                            else
                            {
                                //Detta blocket är en felhantering om användaren skriver något annat än siffror.
                                Console.WriteLine("\n\tVad ska det här föreställa?");
                            }
                            QuitToMenu();
                            break;
                        case 5:
                            Console.Clear();
                            /* I detta caseet ska programmet visa vilka uträkningar som har gjorts.
                             */
                            if (myCalculater.Count <= 0) //Denna if är till för att kolla om det finns några uträkningar.
                            {
                                Console.WriteLine("\n\tDu har inga sparade uträkningar!");
                            }
                            else if (myCalculater.Count > 0) //Annars ska den utföra denna if-sattsen.
                            {
                                Console.WriteLine("\n\tMina sparade uträkningar: ");
                                foreach (double[] number in myCalculater) // För varje number i myCalculater så ska den
                                {
                                    Console.WriteLine("\t" + number[0] + " + " + number[1] + " = " + number[2]); //Skriva ut dom sparade uträkningarna                 
                                }
                            }
                            QuitToMenu();
                            break;
                        case 6: //Caset som avslutar programmet
                            Console.Clear();
                            Console.WriteLine("\n\tTack för du använde miniräknaren!");
                            Console.WriteLine("\n\tHa en bra dag!");
                            myBool = false; //här jag satt myBool till false för att stänga av min loop
                            break;
                        default: //defaulten finns till för om i ALLA ANDRA FALL (än 1-6) så skriver den ut detta. En form av felhantering
                            Console.Clear();
                            Console.WriteLine("\n\tSådär kan du ju inte skriva!");
                            Console.WriteLine("\tDu måste välja mellan menyval 1-5!");
                            QuitToMenu();
                            break;
                    }
                }
                /* En else if är till för att fånga upp om man skriver marcus istället för ett menyval
                 * och den säger "Hej!" för att sedan sätta boolen till false som avslutar programmet.
                 */                
                else if (userInput.ToUpper() == "MARCUS".ToUpper()) // här har jag felhanterat stora och små bokstäver
                {
                    Console.Clear();
                    Console.WriteLine("Hej!");
                    myBool = false;                    
                }
                /* Denna elsen är till för den första if-sattsen som en felhanterare.
                 */
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\tDet där var väl ändå inte rätt!");
                    QuitToMenu();
                }
                /* Förbättringsförslag
                 * - Man kan göra räknesetten med en returnerande klass
                 * - Att kunna räkan flera siffror i samma uträkning
                 * - Kunna använda alla räkneoperatorer i samma uträkning
                 */
            }
        }
    }
}
