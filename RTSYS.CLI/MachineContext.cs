using Microsoft.EntityFrameworkCore;

namespace RTSYS.CLI
{
    public class MachineContext : DbContext
    {

        //DbSet<Machine> Machines { get; set; }

        const string connection =
                            "Data Source=(localdb)\\MSSQLSERVER" +
                            "Database=RTSYS;" +
                            "Integrated Security=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
