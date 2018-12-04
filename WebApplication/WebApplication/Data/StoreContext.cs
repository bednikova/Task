namespace WebApplication.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication.Models;


    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("StoreContext1")
        {
        }

        public DbSet<Owners> Owners { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<OwnersModels> OwnersModels { get; set; }


        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  optionsBuilder.UseSqlite("Data Source=blogging.db");
        //}
    }


}