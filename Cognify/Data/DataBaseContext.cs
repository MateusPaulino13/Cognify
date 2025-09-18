using Microsoft.EntityFrameworkCore;
using System;

namespace Cognify.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        // Define your DbSets here
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
