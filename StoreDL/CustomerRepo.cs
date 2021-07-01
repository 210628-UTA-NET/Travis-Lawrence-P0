using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using StoreModels;

namespace StoreDL
{
    public class CustomerRepo : IRepo<Customer>
    {
        private const string _filepath = "./../StoreDL/Databases/Customers.json";
        private string _jsonString;

        public Customer AddData(Customer p_entry)
        {
            List<Customer> custList = GetAllData();
            custList.Add(p_entry);
            _jsonString = JsonSerializer.Serialize(custList, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, _jsonString);
            return custList[custList.Count-1];
        }

        public List<Customer> GetAllData()
        {
            try
            {
                _jsonString = File.ReadAllText(_filepath);
            }
            catch (System.Exception)
            {
                throw new FileNotFoundException();
            }

            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public Customer GetData(Customer p_entry)
        {
            throw new NotImplementedException();
        }
    }
}