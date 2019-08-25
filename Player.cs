using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Player
    {
        public static string playerName;
        public static int chips;
        
        public static void AddChips(int value)
        {
            chips += value;
        }

        public static void RemoveChips(int value)
        {
            chips -= value;
        }

        public static void SetPlayerName(string input)
        {
            playerName = input;
        }
        public static void Display()
        {
            Console.WriteLine($"{Player.playerName} || Chips: {Player.chips}");
        }
    }
}
