using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{
    class FallingRocks
    {
        static int playerSize = 3;
        static int playerPosition = 10;
        static int rock = 0;
        static Random random = new Random();

        static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void DrawRocks()
        {
            int randomNumber = random.Next(0, 2);
        }

        static void PrintAtPosition(int x,int y,string symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void DrawPlayer()
        {
       
            PrintAtPosition(playerPosition,Console.WindowWidth / 2 - 1, "(0)");
            
        }
        
        static void SetInitialPositions()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
        }

        static void MovePlayerRight()
        {
            if (playerPosition < Console.WindowWidth - playerSize)
            {
                playerPosition++;
            }
        }

        static void MovePlayerLeft()
        {
            if (playerPosition > 0)
            {
                playerPosition--;
            }
        }

        static void Main()
        {
            RemoveScrollBars();
            SetInitialPositions();       
            while (true)
            {
                //move rock
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MovePlayerLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MovePlayerRight();
                    }
                }

                //move rocks
                Console.Clear();
                DrawRocks();
                DrawPlayer();
                Thread.Sleep(150);
            }
        }

       

        
    }
}
