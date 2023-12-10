using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_EF.Configs;
using Task_EF.Entities;
using TaskModel = Task_EF.Entities.Task;

namespace Task_EF.Domain
{
    public class DataContext : DbContext
    {
        private string _connectionString = "Data Source=DESKTOP-IFNFMI9;Initial Catalog=Task_EF;Integrated Security=True;Connect Timeout=60;Encrypt=False;";

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<TaskPerson> TaskPerson { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new TaskPersonConfig());

        }
    }
}
