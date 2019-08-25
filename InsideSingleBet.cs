using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Roulette
{
    class InsideSingleBet
    {

        public List<int> numbersChosen;




        public void InsideBetMenu(int playerBet)
        {
            numbersChosen = new List<int> { };
            AddToList(playerBet);

        }

        public void AddToList(int playerBet)
        {

            Console.Clear();
            Player.Display();
            Console.WriteLine("\nChoose you number to bet on.\n");
            var inputNumbersString = Console.ReadLine();

            if (inputNumbersString == "00")
            {
                numbersChosen.Add(38);
            }
            else if (int.Parse(inputNumbersString) > 36)
            {
                Console.WriteLine("Invalid Number chosed try again.");
                Thread.Sleep(1300);
                AddToList(playerBet);
            }
            else
            {
                var inputInt = int.Parse(inputNumbersString);
                numbersChosen.Add(inputInt);
            }
            
            Console.WriteLine("\nAdd another bet? Y or N");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                Player.RemoveChips(playerBet);
                AddToList(playerBet);
            }

        }

        public void SingleNumberBet(List<int> numbersChosen, string binNumber, int playerBet)
        {

            if (numbersChosen.Contains(int.Parse(binNumber)))
            {
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 36;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);
            }
        }
    }

}
