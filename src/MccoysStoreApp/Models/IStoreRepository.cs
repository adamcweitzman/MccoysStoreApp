using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MccoysStoreApp.Models
{
    public interface IStoreRepository
    {
        IQueryable<Store> StoreList();
        Store GetDetails(string id);
        void Add(Store store);
        void Remove(long key);
        void Update(Store item);
    }
}
