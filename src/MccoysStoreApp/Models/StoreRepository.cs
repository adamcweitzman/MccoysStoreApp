using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MccoysStoreApp.Models
{
    public class StoreRepository : IStoreRepository
    {
        private readonly Store store;

        public void Add(Store store)
        {
            throw new NotImplementedException();
        }

        public Store Find(long key)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Store> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public void Remove(long key)
        {
            
            throw new NotImplementedException();
        }

        public Store GetAll()
        {
            return store;
        }

        public void Update(Store item)
        {
            throw new NotImplementedException();
        }
    }
}
