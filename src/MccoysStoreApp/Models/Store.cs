using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace MccoysStoreApp.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H1TS5BO\LOCALSQLEXPRESS;Initial Catalog=mccoystest;Integrated Security=True");
        }
    }

    [Table("mccoyssampledata")]
    public class Store
    {
        [Key]
        public string StoreNumber { get; set; }

        public string StoreName { get; set; }

        public string StoreManagerName { get; set; }

        public string OpeningTime { get; set; }

        public string ClosingTime { get; set; }

    }

}
