using System;
using System.Collections.Generic;

namespace StoreModels
{

    //To do: regex phone number for proper format
    public class Customer{

        private List<Orders> _customerOrders;

        public Customer()
        {
            Name = "";
            Address = "";
            Email = "";
            PhoneNumber = 0;
            _customerOrders = new List<Orders>();
        }

        public Customer(string p_name, string p_address, string p_email, int p_phone){
            Name = p_name;
            Address = p_address;
            Email = p_email;
            PhoneNumber = p_phone;
            _customerOrders = new List<Orders>();
        }

        public string Name{get; set;}
        public string Address{get; set;}
        public string Email{get; set;}
        public int PhoneNumber{get; set;}
    }

}