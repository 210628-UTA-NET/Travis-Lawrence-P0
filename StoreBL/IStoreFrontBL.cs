using StoreModels;
using System.Collections.Generic;

namespace StoreBL
{
    /// <summary>
    /// Handles the business logic for StoreFronts
    /// </summary>
    public interface IStoreFrontBL{
        /// <summary>
        /// Searches for all StoreFronts by a given name
        /// </summary>
        /// <param name="p_name">The name being searched for</param>
        /// <returns>Returns a list of all StoreFronts will matching names</returns>
        public List<StoreFront> NameSearch(string p_name);

        public bool Update(StoreFront p_store);
    }
}