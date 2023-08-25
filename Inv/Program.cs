using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace Inv
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
    public class ApplicationContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<AddItem> AddItems { get; set; }
        public DbSet<SubItem> SubItems { get; set; }

        public ApplicationContext()
        {
            
            Database.EnsureCreated();
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=WIN-UAQ8QUDRBSS\\INVENTORY;Initial Catalog=Inv;User ID=root;Password=aezakmi89;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Inv;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
}