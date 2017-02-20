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
            throw new NotImplementedException();
        }

        public void Remove(long key)
        {
            
            throw new NotImplementedException();
        }

        public void Update(Store item)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> StoreList()
        {
            Dictionary<string, string> storeNameAndUrlDict = new Dictionary<string, string>();
            using (var db = new StoreContext())
            {
                var numbers = db.Stores
                    .Select(x => x.StoreNumber)
                    .ToList();
                var names = db.Stores
                    .Select(x => x.StoreName)
                    .ToList();

                for (int i = 0; i < numbers.Count; i++)
                {
                    storeNameAndUrlDict.Add(numbers[i].ToString(), string.Format("/store/{0}", numbers[i]));
                }


                return storeNameAndUrlDict;
            }
        }

        public Store StoreDetail()
        {
            throw new NotImplementedException();
        }
    }
}
