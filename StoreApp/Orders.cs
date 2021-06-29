using System;

namespace StoreApp
{
    public class Orders{
        //private List<LineItems> _orderItems;
        private string _location;
        private double _price;

        public Orders(){
            _location = "";
            _price = 0;
        }

        public string Location{get => _location; set => _location = value;}
        public double Price{get => _price; set => _price = value;}
    }
}