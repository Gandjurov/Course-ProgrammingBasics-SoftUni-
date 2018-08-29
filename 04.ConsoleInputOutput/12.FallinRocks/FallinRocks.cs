using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


struct Rock
    {
    public int x;
    public int y;
    public char symbol;
    public ConsoleColor color;
    }

class FallingRocks
    {
    static int playerPosicion = 0;
    static int playerSize = 3;
    static List<Rock> rocks = new List<Rock>();
    static List<Rock> newList = new List<Rock>();

    static void RemoveScrollBars()
        {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        }

    static void PrintAtPosicin(int x, int y, char symbol,
        ConsoleColor color = ConsoleColor.Green)
        {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
        }

    static void DrowPlayer()
        {
        PrintAtPosicin(playerPosicion, Console.WindowHeight - 1, '(');
        PrintAtPosicin(playerPosicion + 1, Console.WindowHeight - 1, '0');
        PrintAtPosicin(playerPosicion + 2, Console.WindowHeight - 1, ')');
        }

    static void MovePlayerRight()
        {
        if (playerPosicion < Console.WindowWidth - playerSize - 1)
            {
            playerPosicion++;
            }
        }

    static void MovePlayerLeft()
        {
        if (playerPosicion > 0)
            {
            playerPosicion--;
            }
        }

    static void DrowRocks()
        {
        foreach (Rock rock in rocks)
            {
            PrintAtPosicin(rock.x, rock.y, rock.symbol, rock.color);
            }
        }

    static void MoveRocks()
        {
        for (int i = 0; i < rocks.Count; i++)
            {
            Rock oldRock = rocks[i];
            Rock rockNew = new Rock();
            rockNew.x = oldRock.x;
            rockNew.y = oldRock.y + 1;
            rockNew.color = oldRock.color;
            rockNew.symbol = oldRock.symbol;
            if (rockNew.y < Console.WindowHeight)
                {
                newList.Add(rockNew);
                }
            rocks = newList;
            }
        }

    static void Main()
        {
        RemoveScrollBars();
        DrowPlayer();
        Random randomGenerator = new Random();
        while (true)
            {
            Rock newRock = new Rock();
            newRock.color = ConsoleColor.White;
            newRock.x = randomGenerator.Next(0, Console.WindowWidth - 1);
            newRock.y = 0;
            newRock.symbol = '&';
            rocks.Add(newRock);

            if (Console.KeyAvailable)
                {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable)
                    {
                    Console.ReadKey(true);
                    }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                    MovePlayerLeft();
                    }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                    MovePlayerRight();
                    }
                }
            MoveRocks();//move rocks
            //check if rocks hitting us
            Console.Clear();//clear the consol
            DrowPlayer();//redrow playfield
            DrowRocks();
            //drow result
            Thread.Sleep(150);//Slow down program
            }
        }
    }
    