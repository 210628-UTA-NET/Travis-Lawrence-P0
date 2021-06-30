using System;

namespace StoreModels
{
    public class Products{
        public Products(){
            Name = "";
            Price = 0;
            Desc = "N/A";
            Category = "N/A";
        }
        public Products(string p_name, double p_price){
            Name = p_name;
            Price = p_price;
            Desc = "N/A";
            Category = "N/A";
        }
        public Products(string p_name, double p_price, string p_desc, string p_cat){
            Name = p_name;
            Price = p_price;
            Desc = p_desc;
            Category = p_cat;
        }

        public string Name{get; set;}
        public double Price{get; set;}
        public string Desc{get; set;}
        public string Category{get; set;}
    }
}