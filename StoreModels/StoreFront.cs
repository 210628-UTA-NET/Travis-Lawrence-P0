using System;

namespace StoreModels
{
    public class StoreFront{
        private string _name;
        private string _address;
        //private List<LineItems> _inventory;
        //private List<Orders> _orders;

        public StoreFront(){
            _name = "";
            _address = "";
        }

        public string Name{get => _name; set => _name = value;}
        public string Address{get => _address; set => _address = value;}
    }
}