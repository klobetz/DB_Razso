using BlazorApp_DB_Entity.Modell;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_DB_Entity.Data
{
    public class MySql_DB_Context : DbContext
    {
        public MySql_DB_Context(DbContextOptions<MySql_DB_Context> options) : base(options) { }
        public DbSet<User> User { get; set; } = default;
    }
}
