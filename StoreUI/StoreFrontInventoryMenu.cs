using System;
using System.Collections.Generic;
using StoreModels;
using StoreBL;

namespace StoreUI
{
    public class StoreFrontInventoryMenu : IMenu
    {
        private static List<StoreFront> _storeFronts = new List<StoreFront>();
        private IStoreFrontBL _storeFrontBL;

        public StoreFrontInventoryMenu(StoreFrontBL p_storeFrontBL){
            _storeFrontBL = p_storeFrontBL;
        }

        public MenuType choice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    return MenuType.StoreFrontMenu;
                case "1":
                    System.Console.WriteLine("Please enter a Store Front's name");
                    try
                    {
                        _storeFronts = _storeFrontBL.NameSearch(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        throw;
                    }

                    if(_storeFronts.Count == 0){
                        System.Console.WriteLine("No stores with that name were found");
                        System.Console.WriteLine("Press Enter to return");
                        Console.ReadLine();
                        return MenuType.StoreFrontInventoryMenu;
                    }
                    foreach(StoreFront s in _storeFronts){
                        System.Console.WriteLine("====================");
                        System.Console.WriteLine("Store Name: " + s.Name);
                        System.Console.WriteLine("Inventory: ");
                        if(s.Inventory.Count == 0){
                            System.Console.WriteLine("Store currently has no inventory");
                        }
                        else{
                            System.Console.WriteLine(s.Inventory);
                        }
                        System.Console.WriteLine("====================");
                    }
                    System.Console.WriteLine("Press Enter to return");
                    Console.ReadLine();
                    return MenuType.StoreFrontInventoryMenu;
                default:
                    return MenuType.Invalid;
            }
        }

        public void dispMenu()
        {
            System.Console.WriteLine("<---See Inventory--->");
            System.Console.WriteLine("[1] Search for a Store Front");
            System.Console.WriteLine("[0] Back");
        }
    }
}