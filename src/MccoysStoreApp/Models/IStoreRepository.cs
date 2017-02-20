using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MccoysStoreApp.Models
{
    public interface IStoreRepository
    {
        List<string> StoreList();
        Store StoreDetail();
        void Add(Store store);
        void Remove(long key);
        void Update(Store item);
    }
}
