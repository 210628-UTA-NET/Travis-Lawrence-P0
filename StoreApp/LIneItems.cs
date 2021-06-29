using System;

namespace StoreApp
{
    public class LineItems{
        //private Products _product;
        private int _quantity;

        public LineItems(){
            _quantity = 0;
        }

        public int Quantity{get => _quantity; set => _quantity = value;}
    }
}