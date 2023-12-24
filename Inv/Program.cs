using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using System.Drawing;
using System;

namespace Inv
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ConnectionForm());
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
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["ConnectionString"]);
        }
    }
}