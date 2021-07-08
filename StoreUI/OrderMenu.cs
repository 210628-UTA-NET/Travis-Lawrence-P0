using System;

namespace StoreUI
{
    public class OrderMenu : IMenu
    {
        public MenuType choice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.OrderPlaceMenu;
                default:
                    return MenuType.Invalid;
            }
        }

        public void dispMenu()
        {
            System.Console.WriteLine("<---Order Menu--->");
            System.Console.WriteLine("[1] Place an order");
            System.Console.WriteLine("[0] Back to main menu");
        }
    }
}