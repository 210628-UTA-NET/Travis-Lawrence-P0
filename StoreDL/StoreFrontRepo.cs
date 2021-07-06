using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using StoreModels;

namespace StoreDL
{
    public class StoreFrontRepo : IStoreFrontRepo
    {
        private const string _filepath = "./../StoreDL/Databases/StoreFronts.json";
        private string _jsonString;

        public StoreFront AddData(StoreFront p_entry)
        {
            throw new System.NotImplementedException();
        }

        public List<StoreFront> GetAllData()
        {
            try
            {
                _jsonString = File.ReadAllText(_filepath);
            }
            catch (System.Exception)
            {
                throw new FileNotFoundException();
            }
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

        public List<StoreFront> NameSearch(string p_name)
        {
            List<StoreFront> storeFList = GetAllData();
            List<StoreFront> retStoreF = new List<StoreFront>();
            foreach(StoreFront s in storeFList){
                if(s.Name == p_name){
                    retStoreF.Add(s);
                }
            }
            return retStoreF;
        }
    }
}