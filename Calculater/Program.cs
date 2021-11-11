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
             *Har även lagt till färgen gul på texten med svart backgrund för att användaren
             *lätt kan se skillnad. Allt detta tillsammans har jag valt att använda för att
             * göra mitt program så användarvänligt som möjligt. Jag har fått läta mig att
             * man inte ska lita på att sin användare gör rätt.
             */
            Console.ForegroundColor = ConsoleColor.Yellow; // Ändrar textens färg till gul
            Console.BackgroundColor = ConsoleColor.Black; // Ändrar bakgrunden för texten, men inte för hela fönstret. (Ser ut som en uråldrig text från svt :'D)
            Console.WriteLine("\n\tFör att komma tillbaka till menyn, tryck på enter"); // Skriver ut en text för att användaren ska vet vad den ska göra
            Console.ReadLine(); // En readline för att programmet ska stanna upp för att visa min WriteLine-text
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // Ändrar tillbaka till ursprungsfärgen på texten.
            Console.BackgroundColor = ConsoleColor.DarkCyan; // Ändrar tillbaka till ursprungsfärgen
        }
        static void Main(string[] args)
        {
            /* Här börjar mainsidan. Allt ovenför är metoder och klasser.
             * Jag har även skapat listan utanför loopen för annars raderas
             * den när loopen börjar om igen.
             */
            Console.BackgroundColor = ConsoleColor.DarkCyan; // Backkgrundfärg
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // Textens färg            
            List<string> myCalculater = new List<string> { }; // Här har jag skapat en sträng-lista
            string calc = ""; // deklaration av en tom sträng för att kunna spara mina uträkningar
            /* Här har jag skapat min bool (som enbart kan innehålla ett sant 
             * eller falskt värde) som kontrollerar loopen.
             * Sålänge (while) loopen är true (påsåendet är sant) så kommer
             * loopen att fortsätta runt. Tills användaren väljer att 
             * avsluta programmet genom att välja i menyn eller skriver MaRcUs.
             */
            bool myBool = true;
            /* Här börjar min while-loop.
             * Jag tycker det är enkelt att använda en bool som vilkor
             * då användaren kan ge användaren ett val att stänga av programmet.
             */            
            while (myBool)
            {
                /* Här börjar min meny jag har valt att använda. Och till menyn har jag
                 * valt att använda mig av en switch då den passar bra till just menyval.
                 *\n gör att jag får en ny rad, \t tabbar in raderna ett steg.
                 * Jag tycker meny är ett snyggt val och det gör användaren mer 
                 * begränsad att göra fel. Jag har gjort ett enklare förslag nedanför.
                 */
                Console.Clear(); // Rensar skärmen och går vidare till nästa skärm
                Console.WriteLine("\n\tHej och välkommen till miniräknaren!");                
                Console.WriteLine("\t====================================");
                Console.WriteLine("\n\t>>> Vänligen välj en operator <<<");
                Console.WriteLine("\n\t[1] - Addition");                
                Console.WriteLine("\t[2] - Subtraktion");
                Console.WriteLine("\t[3] - Multiplikation");
                Console.WriteLine("\t[4] - Divition");
                Console.WriteLine("\t[5] - Visa mina sparade uträkningar");
                Console.WriteLine("\t[6] - Avsluta eller skriv Marcus");
                /* Jag har valt att lägga min switch inom en if-statement som en felhantering.
                 * Inom parantesen har jag en annan felhantering om användaren skriver fel
                 * så att programmet inte ska krascha. Userinputen måste också stå inom loopen
                 * då vi inte vill att detta valet ska sparas.
                 * 
                 */
                string read = Console.ReadLine(); // Här är strängen som fångar upp användarens menyval
                /* Detta första if-blocket är en felhantering, om användaren skriver marcus (oavsett 
                 * stora eller små bokstäver) så säger programmet "Hej!" och stänger av sig.
                 */
                if (read.ToUpper() == "MARCUS") // här har jag felhanterat stora och små bokstäver
                {
                    Console.Clear();
                    Console.WriteLine("\n\tHej!");
                    myBool = false; // här stänger jag av boolen som stänger av while-loopen och programmet stängs
                }
                else //Konverterar userInput till en int
                {
                    if (!Int32.TryParse(read, out int userInput))//Konverterar userInput till en int, en felhantering
                    {
                        userInput = 0;
                    }
                    /* userInput är vad användaren knappar in från menyn.
                     * Switchen innehåller 6 cases och en default. Jag har använt ett
                     * case för varje räkneoperator.
                     */
                    switch (userInput)
                    {
                        case 1:
                            Console.Clear(); // För att rensa skärmen                    
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number1)) // Ytterligare en felhantering
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number2)) // Felhantering
                                {
                                    double resault = number1 + number2; // här ger jag resultatet värdet av första siffran plus andra siffran
                                    Console.WriteLine($"\n\tResultat: {number1} + {number2} = " + resault); //Uträkning
                                    calc = $"\n\t{number1} + {number2} = {resault}"; // detta blir en sträng av min uträkning för att jag ska kunna spara den någonstanns
                                    myCalculater.Add(calc); // här lägger jag till min sparade sträng calc i min lista
                                }
                                else
                                {
                                    /* I detta blocket skickar jag felhanteringen om användaren skriver något annat
                                    * än vad programmet vill, annars hade programmet kraschat.
                                    */
                                    Console.WriteLine("Hur tänkte du nu??");
                                }
                            }
                            else //felhantering
                            {
                                Console.WriteLine("\n\tDu har nog aldrig räknat förr...");
                            }
                            QuitToMenu(); // Metoden som jag gjort som skickar användaren tillbaka till menyn
                            break;
                        case 2:
                            Console.Clear();                            
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number3)) //Felhantering
                            {                                                    
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number4)) //Felhantering
                                {
                                    double resault = number3 - number4;
                                    Console.WriteLine($"\n\tResultat: {number3} - {number4} = " + resault); // Uträkning
                                    calc = $"\n\t{number3} - {number4} = { resault}";
                                    myCalculater.Add(calc);
                                }
                                else
                                {
                                    Console.WriteLine("Nu blev det lite tokigt...");
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
                            Console.WriteLine("\n\tSkriv in ditt första tal: ");
                            if (double.TryParse(Console.ReadLine(), out double number5))
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number6))
                                {
                                    double resault = number5 * number6;
                                    Console.WriteLine($"\n\tResultat: {number5} * {number6} = " + resault);
                                    calc = $"\n\t{number5} * {number6} = {resault}";
                                    myCalculater.Add(calc);
                                }
                                else
                                {
                                    Console.WriteLine("Jävla pucko..........");
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
                            if (double.TryParse(Console.ReadLine(), out double number7))
                            {
                                Console.WriteLine("\n\tSkriv in ditt andra tal: ");
                                if (double.TryParse(Console.ReadLine(), out double number8))
                                {
                                    double resault = number7 / number8;
                                    /* I detta if-blocket har jag felhanterat att det inte går att dela med noll,
                                     * annars ska den göra en en uträkning.
                                     */
                                    while (number8 == 0)
                                    {
                                        //Detta händer när man försöker dela med noll
                                        // while-loopen fortsätter tills användaren skriver en gilltlig siffra.
                                        Console.WriteLine("\n\tDet där går ju inte att dela med...");
                                        Console.WriteLine("\n\tFörsök med ett nytt tal: ");
                                        number8 = Convert.ToDouble(Console.ReadLine());
                                    }                                
                                    Console.WriteLine($"\n\tResultat: {number7} / {number8} = " + resault);
                                    calc = $"\n\t{number7} * {number8} =  {resault}";
                                    myCalculater.Add(calc);                                    
                                }
                                else
                                {
                                    Console.WriteLine("*facepalm*");
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
                                    foreach (string number in myCalculater) // För varje number i myCalculater så ska den...
                                    {
                                    Console.ForegroundColor = ConsoleColor.Red; // Här jag jag gjort texten röd för att göra det tydligt för användaren.
                                    Console.WriteLine("\t" + number); // ...skriva ut dom sparade uträkningarna              
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
                // Jag har valt att ha mång ställen att felhantera på då jag inte vill att min program ska krascha.
                // 

                /* Förbättringsförslag
                 * - Man kan göra räknesätten med en returnerande klass
                 * - Att kunna räkan flera siffror i samma uträkning, med hjälp av en while-loop
                 * - Kunna använda flera räkneoperatorer i samma uträkning
                 */
            }
            // Här nedanför har jag en enklare variant. Dock är den inte lika användarvänlig
            // då den inte har någon felhantering och har stor risk för att krasha,
            // men den har betydligt mindre kod. Denna kod nedanför följer instruktionen på Learnpoint
            // lite mer än vad min meny gör, men jag gillar meny haha.

            //List<string> myHistoryList = new List<string>();
            //string history = "";
            //bool myBool = true;
            //while (myBool)
            //{
            //    Console.WriteLine("Skriv en siffra: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());                
            //    Console.WriteLine("Välj en operator: +, -, * eller /");
            //    string op = Console.ReadLine();
            //    if (op.ToUpper() == "MARCUS")
            //    {
            //        Console.WriteLine("Hej!");
            //        myBool = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Skriv en siffra till");
            //        double num2 = Convert.ToDouble(Console.ReadLine());

            //        switch (op)
            //        {
            //            case "+":
            //                double result = num1 + num2;
            //                Console.WriteLine($"Resultat: {num1} + {num2} = " + (num1 + num2));
            //                history = $"{num1} + {num2} = " + result;
            //                break;
            //            case "-":
            //                result = num1 - num2;
            //                Console.WriteLine($"Resultat: {num1} - {num2} = " + (num1 - num2));
            //                history = $"{num1} - {num2} = " + result;
            //                break;
            //            case "*":
            //                result = num1 - num2;
            //                Console.WriteLine($"Resultat: {num1} - {num2} = " + (num1 - num2));
            //                history = $"{num1} - {num2} = " + result;
            //                break;
            //            case "/":
            //                result = num1 - num2;
            //                while (num2 == 0)
            //                {
            //                    Console.WriteLine("Du kan inte dela med noll! Vänligen försök igen");
            //                    num2 = Convert.ToDouble(Console.ReadLine());
            //                }
            //                Console.WriteLine($"Resultat: {num1} - {num2} = " + (num1 - num2));
            //                history = $"{num1} - {num2} = " + result;
            //                break;
            //            default:
            //                Console.WriteLine("WRONG! Försök igen!");
            //                break;

            //        }
            //        myHistoryList.Add(history);
            //    }
            //    Console.WriteLine("Historik");
            //    foreach (string item in myHistoryList)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();
        }
    }
}
