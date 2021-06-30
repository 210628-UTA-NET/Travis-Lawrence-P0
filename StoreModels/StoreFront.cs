using System;
using System.Collections.Generic;

namespace StoreModels
{
    public class StoreFront{
        private List<LineItems> _inventory;
        private List<Orders> _orders;

        public StoreFront(){
            Name = "";
            Address = "";
            _inventory = new List<LineItems>();
            _orders = new List<Orders>();
        }
        public StoreFront(string p_name, string p_addr){
            Name = p_name;
            Address = p_addr;
            _inventory = new List<LineItems>();
            _orders = new List<Orders>();
        }

        public string Name{get; set;}
        public string Address{get; set;}
    }
}