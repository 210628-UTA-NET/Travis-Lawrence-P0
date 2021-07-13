using StoreModels;

namespace StoreBL
{
    public interface IOrderBL : IBL<Orders>{
        Orders PlaceOrder(Orders p_entry, Customer p_cust, StoreFront p_store);
    }
}