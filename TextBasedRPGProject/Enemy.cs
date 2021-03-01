﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Enemy : GameCharacter
    {
        Random random = new Random();
       
        public Enemy()
        {
            avatar = 'E';
            name = "Slime";
            positionX = Console.WindowWidth / 4;
            positionY = Console.WindowHeight / 4;
            health = 1;
        }
        public void Update(Map map)
        {
            int rnd = random.Next(5);
            switch (rnd)
            {
                case 0:
                    if (!map.IsWall(positionX, positionY + 1)) positionY++;
                    break;
                case 1:
                    if (!map.IsWall(positionX, positionY - 1)) positionY--;
                    break;
                case 2:
                    if (!map.IsWall(positionX - 1, positionY)) positionX--;
                    break;
                case 3:
                    if (!map.IsWall(positionX + 1, positionY)) positionX++;
                    break;
                case 4:
                    break;
            }
        }
      
    }
}
