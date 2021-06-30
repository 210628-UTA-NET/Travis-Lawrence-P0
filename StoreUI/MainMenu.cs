using System;

namespace StoreUI
{
    public class MainMenu : IMenu
    {
        public MenuType choice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.CustomerMenu;
                default:
                    return MenuType.Invalid;
            }
        }

        public void dispMenu()
        {
            System.Console.WriteLine("<===Main Menu===>");
            System.Console.WriteLine("Please select an option.");
            System.Console.WriteLine("[1] Customer menu");
            System.Console.WriteLine("[0] Exit");
        }
    }
}