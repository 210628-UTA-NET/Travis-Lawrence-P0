using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface ICustomerBL : IBL<Customer>{
        public List<Customer> NameSearch(string p_name);
    }
}