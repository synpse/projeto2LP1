﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2_LP1
{
    class Controls
    {
        Grid grid = new Grid();
        Renderer renderer = new Renderer();
        Surroundings scan = new Surroundings();
        Initializer init = new Initializer();

        public void CheckInputs(Initializer init, Grid grid)
        {
            bool playing = true;
            bool quitConfirm = true;

            while (playing == true)
            {
                ConsoleKeyInfo selectedKey = Console.ReadKey();

                switch (selectedKey.Key)
                {
                    case ConsoleKey.W:
                        if (grid.playerX > 0)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerX -= 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "NORTH";
                        }
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.S:
                        if (grid.playerX < 7)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerX += 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "SOUTH";
                        }
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.A:
                        if (grid.playerY > 0)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerY -= 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "WEST";
                        }
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.D:
                        if (grid.playerY < 7)
                        {
                            grid.array[grid.playerX, grid.playerY].Remove(init.player);
                            grid.playerY += 1;
                            grid.array[grid.playerX, grid.playerY].Add(init.player);
                            playing = false;
                            grid.moved = "EAST";
                        }
                        Console.SetCursorPosition(42, 39);
                        Console.WriteLine(" - I can't move on that direction!");
                        break;
                    case ConsoleKey.E:
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food1))
                        {
                            init.player.Hp += init.food1.Heal;
                            grid.array[grid.playerX, grid.playerY].Remove(init.food1);
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food2))
                        {
                            init.player.Hp += init.food2.Heal;
                            grid.array[grid.playerX, grid.playerY].Remove(init.food2);
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.food3))
                        {
                            init.player.Hp += init.food3.Heal;
                            grid.array[grid.playerX, grid.playerY].Remove(init.food3);
                            playing = false;
                        }
                        if (grid.array[grid.playerX, grid.playerY].Contains(init.map))
                        {
                            for (int row = 0; row < 8; row++)
                            {
                                for (int column = 0; column < 8; column++)
                                {
                                    grid.array[row, column].Explored = true;
                                    init.exit.Explored = true;
                                    init.trap1.Explored = true;
                                    init.trap2.Explored = true;
                                    init.trap3.Explored = true;
                                    init.food1.Explored = true;
                                    init.food2.Explored = true;
                                    init.food3.Explored = true;
                                    init.npc.Explored = true;
                                }
                            }
                            grid.array[grid.playerX, grid.playerY].Remove(init.map);
                            playing = false;
                        }
                        break;
                    case ConsoleKey.I:
                        if (grid.playerY < 7)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine("╔═════════════════════════════════════════════════════" +
                                "══════════════════════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(54, 2);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("[More Info]");
                            Console.ResetColor();
                            Console.SetCursorPosition(48, 9);
                            Console.WriteLine("Recurso's Damage: 0 - 78");
                            Console.SetCursorPosition(49, 12);
                            Console.WriteLine("Spike's Damage: 0 - 22");
                            Console.SetCursorPosition(50, 15);
                            Console.WriteLine("Hole's Damage: 0 - 10");

                            Console.SetCursorPosition(0, 36);
                            Console.WriteLine("╚═════════════════════════════════════════════════════" +
                                "══════════════════════════════════════════════════════════════════╝");
                            Console.SetCursorPosition(127, 1);
                            Console.WriteLine("╔════════════════════════" +
                                "══════════════════════════════════════╗");
                            // Status
                            Console.SetCursorPosition(140, 2);
                            Console.Write("[Status]");
                            Console.SetCursorPosition(135, 5);
                            Console.Write($"Current Level: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{init.level:000}");
                            Console.ResetColor();
                            Console.SetCursorPosition(135, 8);
                            Console.Write("Player HP: ");
                            if (init.player.Hp > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (init.player.Hp <= 50 && init.player.Hp > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else if (init.player.Hp <= 20 && init.player.Hp > 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (init.player.Hp <= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            Console.Write($"{init.player.Hp:000}");
                            Console.ResetColor();

                            // Info
                            Console.SetCursorPosition(172, 2);
                            Console.Write("[Info]");
                            Console.SetCursorPosition(168, 5);
                            Console.Write("Player - ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\u2302");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 8);
                            Console.Write("Explored - .");
                            Console.SetCursorPosition(168, 11);
                            Console.Write("Unexplored - ~");
                            Console.SetCursorPosition(168, 14);
                            Console.Write("Exit - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("E X I T !");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 17);
                            Console.Write("Trap - ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\u25B2");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 20);
                            Console.Write("Food - ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\u2665");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 23);
                            Console.Write("Neutral NPC - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\u25CA");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 26);
                            Console.Write("Hostile NPC - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\u2666");
                            Console.ResetColor();
                            Console.SetCursorPosition(168, 29);
                            Console.Write("Map - ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\u263C");
                            Console.ResetColor();

                            Console.SetCursorPosition(127, 36);
                            Console.WriteLine("╚════════════════════════" +
                                "══════════════════════════════════════╝");

                            Console.ReadKey();
                            renderer.Render(init, grid);
                            scan.Scan(init, grid);
                        }
                        break;
                    case ConsoleKey.Q:
                        Console.SetCursorPosition(41, 39);
                        Console.WriteLine("Are you sure you want to quit? (Y/N)");
                        while (quitConfirm)
                        {
                            ConsoleKeyInfo quitKey = Console.ReadKey();
                            if (selectedKey.Key != ConsoleKey.Y ||
                                selectedKey.Key != ConsoleKey.N)
                            {
                                Console.SetCursorPosition(41, 39);
                                Console.WriteLine("Are you sure you want to quit? (Y/N)");
                            }
                            else
                            {
                                break;
                            }

                            switch (quitKey.Key)
                            {
                                case ConsoleKey.Y:
                                    Console.SetCursorPosition(42, 41);
                                    MainMenu.Display();
                                    break;
                                case ConsoleKey.N:
                                    quitConfirm = false;
                                    Console.SetCursorPosition(49, 41);
                                    Console.WriteLine("Quiting aborted!");
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}