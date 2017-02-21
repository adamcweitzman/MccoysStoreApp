using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MccoysStoreApp.Models
{
    public class StoreRepository :  IStoreRepository
    {
        public class StoreContext : DbContext
        {
            public DbSet<Store> Stores { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H1TS5BO\LOCALSQLEXPRESS;Initial Catalog=mccoystest;Integrated Security=True");
            }
        }

        public void Add(Store store)
        {
            StoreContext storeContext = new StoreContext();
            storeContext.Stores.Add(store);
            storeContext.SaveChanges();
        }

        public void Remove(long key)
        {
            
            throw new NotImplementedException();
        }

        public void Update(Store item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Store> StoreList()
        {
            StoreContext storeContext = new StoreContext();
            var ans = storeContext.Set<Store>();

            return ans;
        }

        public Store GetDetails(string id)
        {
            StoreContext storeContext = new StoreContext();
            Store storeDetails = storeContext.Stores.First(s => s.StoreNumber == id);

            return storeDetails;
        }

        private void CleanDataAndStore()
        {
            throw new NotImplementedException();
        }
    }
}
