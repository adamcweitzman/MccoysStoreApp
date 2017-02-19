using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MccoysStoreApp.Models
{
    public interface IStoreRepository
    {
        void Add(Store store);
        Store GetAll();
        Store Find(long key);
        void Remove(long key);
        void Update(Store item);
    }
}
