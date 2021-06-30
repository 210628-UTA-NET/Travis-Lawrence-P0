using System;
using System.Collections.Generic;

namespace StoreModels
{
    public class Orders{
        private List<LineItems> _orderItems;

        public Orders(){
            Location = "";
            Price = 0;
            _orderItems = new List<LineItems>();
        }
        public Orders(string p_loc, double p_price){
            Location = p_loc;
            Price = p_price;
            _orderItems = new List<LineItems>();
        }

        public string Location{get; set;}
        public double Price{get; set;}
    }
}