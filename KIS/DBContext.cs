using Microsoft.EntityFrameworkCore;
using KIS.Models;

namespace KIS
{

    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DbSet<SpecificationModel> Specifications { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<StorageModel> Storages { get; set; }

    }
}
