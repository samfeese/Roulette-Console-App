using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Roulette
{
    class Wheel
    {
        string[,] wheelValues = new string[38, 2]{ { "0", "GRN" },{ "1", "RED" },{ "2", "BLK" }, { "3", "RED" }, { "4", "BLK" },
                                                    { "5", "RED" }, { "6", "BLK" }, { "7", "RED" }, { "8", "BLK" }, { "9", "RED" },
                                                        { "10", "BLK" },{ "11", "BLK" },{ "12", "RED" },{ "13", "BLK" },{ "14", "RED" },
                                                            { "15", "BLK" },{ "16", "RED" },{ "17", "BLK" },{ "18", "RED" },{ "19", "BLK" },
                                                                { "20", "BLK" },{ "21", "RED" },{ "22", "BLK" },{ "23", "RED" },{ "24", "BLK" },
                                                                    { "25", "RED" },{ "26", "BLK" },{ "27", "RED" },{ "28", "RED" },{ "29", "BLK" },
                                                                        { "30", "RED" },{ "31", "BLK" },{ "32", "RED" },{ "33", "BLK" },{ "34", "RED" },
                                                                            { "35", "BLK" },{ "36", "RED" },{ "00", "GRN" }};
        List<string> previousSpinsValue = new List<string>();
        List<string> previousSpinsColor = new List<string>();

        public Wheel()
        {
            SetWheelValues();
        }

        public void SetWheelValues()
        {
         
         
               
        }

        public (string, string) SpinTheWheel()
        {
            Console.Clear();
            //Console.WriteLine("Here we go spinning the Wheel! Good Luck!");
            //Thread.Sleep(3000);
            //Console.WriteLine("\nAll Bets Closed!");
            //Thread.Sleep(3000);

            Random rand = new Random();

            var spinResult = rand.Next(0, 37);
            //Console.WriteLine($"\nThe ball bounces and clips a canoe, landing on............");
            //Thread.Sleep(3000);
            Console.WriteLine($"\n\n{wheelValues[spinResult, 1]}, {wheelValues[spinResult, 0]}!!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            return (wheelValues[spinResult, 0], wheelValues[spinResult, 1]);
            
          
        }
        public void SaveSpins((string, string) lastSpin)
        {
            previousSpinsValue.Add(lastSpin.Item1);
            previousSpinsColor.Add(lastSpin.Item2);

        }

        public void ShowPastSpins()
        {
            if (previousSpinsValue.Count < 10) 
            {
                foreach(var i in previousSpinsValue)
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = previousSpinsValue.Count - 10; i < previousSpinsValue.Count; i++)
                {
                    if (previousSpinsColor[i] == "RED")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"\n{previousSpinsColor[i]} {previousSpinsValue[i]}");
                     
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (previousSpinsColor[i] == "BLK")
                    {

                        Console.Write($"\n{previousSpinsColor[i]} {previousSpinsValue[i]}");

                    }
                    if (previousSpinsColor[i] == "GRN")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;

                        Console.Write($"\n{previousSpinsColor[i]} {previousSpinsValue[i]}");

                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }


    }


}
