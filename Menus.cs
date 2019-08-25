using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Roulette
{
    class Menus
    {
        

       
        public Menus()
        {
            Console.WriteLine("What is your Name?");
            string input = Console.ReadLine();
            Player.SetPlayerName(input);
            Player.AddChips(1000000);
            MainMenu();
            
        }
        public Wheel spin = new Wheel();
        public OutsideBetOutput bets = new OutsideBetOutput();
        public InsideSingleBet inside = new InsideSingleBet();
        public void MainMenu()
        {

            Console.Clear();
            Player.Display();
            Console.WriteLine("WELCOME TO ROULETTE!");
            Console.WriteLine();

            Console.WriteLine("Press B to bet, P to show past results.");
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
                else if (playerInput.Key == ConsoleKey.B)
                {
                    BettingMenu();
                }
                MainMenu();
            }
        }
        public void BettingMenu()
        {
            Console.Clear();
            Player.Display();
            Console.WriteLine("How much would you like to bet?");

            int playerBet = int.Parse(Console.ReadLine());
            if (playerBet < Player.chips)
            {
                Player.RemoveChips(playerBet);

            }
            else
            {
                Console.WriteLine("You do not have enough chips");
                BettingMenu();
            }
            Console.WriteLine($"You are betting {playerBet}.");
            Thread.Sleep(1500);

            Console.Clear();
            Player.Display();

            Console.WriteLine("Please select your type of bet. \n\n 1: Outside Bet || 2: Inside individual bet || 3: SplitBet");
            var playerbetChoice = Console.ReadKey();
            switch (playerbetChoice.Key)
            {
                case ConsoleKey.D1:
                    OutsideBetMenu(playerBet);
                    
                    break;

                case ConsoleKey.D2:
                    inside.InsideBetMenu(playerBet);
                    spin.SaveSpins(spin.SpinTheWheel());

                    inside.SingleNumberBet(inside.numbersChosen, spin.ShowLastNumber(), playerBet);
                    break;

                case ConsoleKey.D3:
                    SplitBetMenu();
                    break;
                default:
                    BettingMenu();
                    break;

            }

        }
        public void OutsideBetMenu(int playerBet)
        {
            Console.WriteLine($"You have chosen an outside bet of {playerBet}!");
            Console.WriteLine("What bet would you like to make?");
            Console.WriteLine("1: Black (1:1) ||\n 2: Red (1:1) ||\n 3: 1st 12 (2:1) " +
                                "||\n 4: 2nd 12 (2:1) ||\n 5: 3rd 12 (2:1) ||\n 6: Odd (1:1) " +
                                "||\n 7: Even (1:1) ||\n 8: Low 1-18 (1:1) ||\n 9: High 19-36 (1:1) " +
                                "||\n 0: Column 1 (2:1) ||\n F1: Column 2 (2:1) ||\nF2: Column 3 (2:1)");
            var betChoice = Console.ReadKey();
            switch (betChoice.Key)
            {
                case ConsoleKey.D1:
                    spin.SaveSpins(spin.SpinTheWheel());
                   
                    bets.Black(playerBet, spin.ShowLastColor());
                    break;

                case ConsoleKey.D2:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.Red(playerBet, spin.ShowLastColor());
                    break;

                case ConsoleKey.D3:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.FirstDozen(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D4:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.SecondDozen(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D5:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.ThirdDozen(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D6:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.Odd(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D7:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.Even(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D8:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.High(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D9:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.Low(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.D0:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.ColumnOne(playerBet, spin.ShowLastNumber());
                    break;
                case ConsoleKey.F1:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.ColumnTwo(playerBet, spin.ShowLastNumber());
                    break;

                case ConsoleKey.F2:
                    spin.SaveSpins(spin.SpinTheWheel());

                    bets.ColumnThree(playerBet, spin.ShowLastNumber());
                    break;




            }
        }

       

        public void SplitBetMenu()
        {

        }



    }
}



    