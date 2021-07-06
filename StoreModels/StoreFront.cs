using System;
using System.Collections.Generic;

namespace StoreModels
{
    public class StoreFront{
        private List<Orders> _orders;

        public StoreFront(){
            Name = "";
            Address = "";
            Inventory = new List<LineItems>();
            _orders = new List<Orders>();
        }
        public StoreFront(string p_name, string p_addr, List<LineItems> p_inventory, List<Orders> p_orders){
            Name = p_name;
            Address = p_addr;
            Inventory = p_inventory;
            _orders = p_orders;
        }

        public string Name{get; set;}
        public string Address{get; set;}

        public List<LineItems> Inventory{get;}
    }
}