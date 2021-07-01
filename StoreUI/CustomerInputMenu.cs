using System;
using System.Collections.Generic;
using StoreModels;

namespace StoreUI
{
    public class CustomerInputMenu{
        private List<Customer> _customers;

        public CustomerInputMenu(){
            _customers = new List<Customer>();
        }
        public void displayMenu(){
            Console.WriteLine("=== Welcome to the Customer Input Menu ===");
            Console.WriteLine("Please select an option.");
            Console.WriteLine("[2] Enter new customer");
            Console.WriteLine("[1] Read all current customer data");
            Console.WriteLine("[0] Exit");
        }

        public string menuChoice(){
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    return "Exit";
                case "1":
                    readCustomers();
                    return "CustomerInputMenu";
                case "2":
                    enterCustomer();
                    return "CustomerInputMenu";
                default:
                    return "Unrecognized";
            }
        }

        private void enterCustomer(){
            Customer newCustomer = new Customer();
            Console.WriteLine("Please enter the customer's name: ");
            newCustomer.Name = getInput();
            Console.WriteLine("Please enter the customer's addresss: ");
            newCustomer.Address = getInput();
            Console.WriteLine("Please enter the customer's email addresss: ");
            newCustomer.Email = getInput();
            Console.WriteLine("Please enter the customer's phone number (no spaces or dashes): ");
            newCustomer.PhoneNumber = Convert.ToInt32(getInput());

            _customers.Add(newCustomer);

            Console.WriteLine("Input successful. Press enter to continue.");
            getInput(); 
        }

        private string getInput(){
            string retValue = null;
            while(retValue == null){
                retValue = Console.ReadLine();
            }
            return retValue;
        }

        private void readCustomers(){
            foreach(Customer c in _customers){
                Console.WriteLine("Name: " + c.Name);
                Console.WriteLine("Address: " + c.Address);
                Console.WriteLine("Email: " + c.Email);
                Console.WriteLine("Phone Number: " + c.PhoneNumber);
                Console.WriteLine("Oders: (Sorry I haven't implemented those yet");
                Console.WriteLine("");
            }

            Console.WriteLine("Press enter to return to the previous menu.");

            getInput();
        }
    }
}