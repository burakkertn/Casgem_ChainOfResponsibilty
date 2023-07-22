using Microsoft.EntityFrameworkCore;

namespace Casgem_ChainOfResponsibilty.DAL
{
    public class Context : DbContext
    {

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=BURAK\\SQLEXPRESS;database= ChainOfRepo;integrated security = true");

            }
            public DbSet<CustomerProcess> CustomerProcesses { get; set; }

 
        }
}
