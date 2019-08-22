using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Menus
    {
        Wheel spin = new Wheel();

        public Menus()
        {
            MainMenu();
        }

        public void MainMenu()
        {

            Console.Clear();
            Console.WriteLine("WELCOME TO ROULETTE!");
            Console.WriteLine();
            Console.WriteLine("Press S to spin, P to show past results.");
            Table.MakeTable();
            var playerInput = Console.ReadKey();
            while (playerInput.Key != ConsoleKey.Escape)
            {
                if (playerInput.Key == ConsoleKey.S)
                {
                    var outputSpin = spin.SpinTheWheel();
                    spin.SaveSpins(outputSpin);

                }
                else if (playerInput.Key == ConsoleKey.P)
                {
                    spin.ShowPastSpins();
                }
                MainMenu();
            }
            Table.MakeTable();
        }

    }
}
