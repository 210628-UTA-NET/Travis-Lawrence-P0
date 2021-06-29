using System;

namespace StoreApp
{
    public class Customer{
        private string _name;
        private string _address;
        private string _email;
        private int _phoneNumber;
        //private List<Orders> _customerOrders;

        public Customer()
        {
            _name = "";
            _address = "";
            _email = "";
            _phoneNumber = 0;
        }

        public Customer(string p_name, string p_address, string p_email, int p_phone){
            _name = p_name;
            _address = p_address;
            _email = p_email;
            _phoneNumber = p_phone;
        }

        public string Name{get => _name; set => _name = value;}
        public string Address{get => _address; set => _address = value;}
        public string Email{get => _email; set => _email = value;}
        public int PhoneNumber{get => _phoneNumber; set => _phoneNumber = value;}
    }

}