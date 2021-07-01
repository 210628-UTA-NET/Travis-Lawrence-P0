using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL : IBL<Customer>
    {
        private IRepo<Customer> _repo;
        public CustomerBL(IRepo<Customer> p_repo){
            _repo = p_repo;
        }

        public Customer AddData(Customer p_entry)
        {
            return _repo.AddData(p_entry);
        }

        public List<Customer> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Customer GetData()
        {
            throw new NotImplementedException();
        }
    }
}