using Microsoft.EntityFrameworkCore;
using TerminalV1.Models;

namespace TerminalV1.Data
{
    public class DbTerminalContext : DbContext
    {
        public DbTerminalContext(DbContextOptions<DbTerminalContext> options) : base(options) 
        {
            
        }
        //Aca van los dbset
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
    }
}
