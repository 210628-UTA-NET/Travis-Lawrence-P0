﻿using System;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new MainMenu();
            bool exit = false;
            MenuType currentMenu = MenuType.MainMenu;
            MenuFactory factory = new MenuFactory();

            while(!exit){
                Console.Clear();
                menu.dispMenu();
                currentMenu = menu.choice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        menu = factory.GetMenu(MenuType.MainMenu);
                        break;
                    case MenuType.CustomerMenu:
                        menu = factory.GetMenu(MenuType.CustomerMenu);
                        break;
                    case MenuType.CustomerAddMenu:
                        menu = factory.GetMenu(MenuType.CustomerAddMenu);
                        break;
                    case MenuType.Exit:
                        exit = true;
                        break;
                    case MenuType.Invalid:
                        System.Console.WriteLine("Error: input not recognized.");
                        System.Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case MenuType.Unfinished:
                        System.Console.WriteLine("Sorry, I'm still working on that one.");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}