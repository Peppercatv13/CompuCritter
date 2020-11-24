using System;
using System.Threading;

namespace CompuCritter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            int critterHappiness = 50;
            int critterHunger = 50;
            int critterHealth = 35;

            bool critterLiving = true;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WELCOME to CompuCritter 1.0, the interactive console pet!");

            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            while (critterLiving)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A digital egg has appeared! What could be inside? If you wait a while, it may hatch!");
                Thread.Sleep(50000);


                Console.WriteLine("The egg is hatching!");


                Thread.Sleep(2000);
                Console.WriteLine("Enter a name for the little guy...");
                string critterName = Console.ReadLine();

                while (critterHappiness > 25 && critterHunger > 25 && critterHealth > 25)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(critterName + " looks hungry...");
                    Console.WriteLine("Type FOOD, TREAT, PLAY, or WALK!");


                    string critterAction = Console.ReadLine();
                    critterAction = critterAction.ToUpper();
                    if (critterAction == "FOOD")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(critterName + " ate the food.");
                        critterHunger++;
                        critterHealth--;
                    }
                    else if (critterAction == "TREAT")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(critterName + " gobbled up the snack!");
                        critterHappiness++;
                        critterHappiness++;
                        critterHealth--;
                        critterHealth--;
                    }
                    else if (critterAction == "PLAY")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(critterName + " fetched the ball, Good job " + critterName + " !");
                        critterHappiness++;
                        critterHunger--;

                    }
                    else if (critterAction == "WALK")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(critterName + " seems to enjoy the fresh air!");
                        critterHealth++;
                        critterHunger--;
                        critterHappiness--;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(critterName + "Looks confused. Try another selection!");
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(critterName);
                    Console.WriteLine("Happiness <3 : " + critterHappiness);
                    Console.WriteLine("Fullness <> : " + critterHunger);
                    Console.WriteLine("Fitness % : " + critterHealth);
                }
                if (critterHappiness > 25 || critterHunger > 25 || critterHealth > 25)
                {
                    critterLiving = false;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(critterName + " has passed away... Rest in peace, little guy.");
                }
            }
        }
    }

}
