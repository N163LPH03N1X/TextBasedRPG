﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Player : GameCharacter
    {
        public Player(Map map)
        {
            SetMap(map);
            avatar = '8';
            name = "N163LPH03N1X";
            fGColor = ConsoleColor.Cyan;
            bGColor = ConsoleColor.Black;
            position.x = Console.WindowWidth / 2;
            position.y = Console.WindowHeight / 2;
            health = 100;
        }
        public void Update()
        {
          
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    TryMove(0, -1);
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    TryMove(0, 1);
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    TryMove(-1, 0);
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    TryMove(1, 0);
                    break;
            }
        }
     
    }
}
