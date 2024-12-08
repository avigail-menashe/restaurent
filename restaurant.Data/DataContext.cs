

using Microsoft.EntityFrameworkCore;
using restaurant.Core.enties;

namespace restaurant.Data
{
    public class DataContext:DbContext

    {
        public DbSet<Client> clients {  get; set; } 
        public DbSet<Order> orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Restaurant");
        }

    }
}
