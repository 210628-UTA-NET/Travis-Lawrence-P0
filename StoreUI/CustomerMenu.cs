using System;

namespace StoreUI
{
    public class CustomerMenu : IMenu
    {
        public MenuType choice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.CustomerInputMenu;
                //Add customer search menu    
                case "2":
                    return MenuType.Unfinished;
                //Add read all customer menu
                case "3":
                    return  MenuType.Unfinished;
                default:
                    return MenuType.Invalid;
            }
        }

        public void dispMenu()
        {
            System.Console.WriteLine("<---Customer Menu--->");
            System.Console.WriteLine("Please select an option.");
            System.Console.WriteLine("[3] Display all customers");
            System.Console.WriteLine("[2] Search for a customer");
            System.Console.WriteLine("[1] Enter data for a new customer");
            System.Console.WriteLine("[0] Back to main menu");
        }
    }
}