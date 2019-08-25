using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Roulette
{
    class OutsideBetOutput
    {
        
        
        public void Black(int playerBet, string color)
        {
            
            if(color == "BLK")
            {
                //1:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 2;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);
            }
        }
        public void Red(int playerBet, string color)
        {

            if (color == "RED")
            {
                //1:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 2;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300); 

            }
        }
        public void Odd(int playerBet, string number)
        {

            if (int.Parse(number)%2 != 0)
            {
                //1:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 2;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300); 

            }
        }
        public void Even(int playerBet, string number)
        {

            if (int.Parse(number) % 2 == 0)
            {
                //1:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 2;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void FirstDozen(int playerBet, string number)
        {

            if (int.Parse(number) < 13)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 3;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void SecondDozen(int playerBet, string number)
        {

            if (int.Parse(number) > 12 && int.Parse(number) < 25)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 3;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void ThirdDozen(int playerBet, string number)
        {

            if (int.Parse(number) > 24 && int.Parse(number) < 37)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 3;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void ColumnOne(int playerBet, string number)
        {
           
            if (int.Parse(number)%3 == 1)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 3;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void Low(int playerBet, string number)
        {

            if (int.Parse(number) < 19)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 2;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void High(int playerBet, string number)
        {

            if (int.Parse(number) > 18)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 2;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void ColumnTwo(int playerBet, string number)
        {

            if (int.Parse(number) % 3 == 2)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 3;
                Player.AddChips(playerBet);
            }
            else
            {
                Console.WriteLine("You lost, better luck next time.");
                Thread.Sleep(1300);

            }
        }
        public void ColumnThree(int playerBet, string number)
        {

            if (int.Parse(number) % 3 == 0)
            {
                //2:1 win
                Console.WriteLine("You Win!");
                Thread.Sleep(1300);
                playerBet *= 3;
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
