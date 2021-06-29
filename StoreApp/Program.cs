using System;

namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInputMenu menu = new CustomerInputMenu();
            bool exit = false;
            string currentMenu = "CustomerInputMenu";

            while(!exit){
                Console.Clear();
                menu.displayMenu();
                currentMenu = menu.menuChoice();

                switch (currentMenu)
                {
                    case "CustomerInputMenu":
                        break;
                    case "Exit":
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
