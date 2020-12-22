using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Med_help
{
    public class ApplicationContext : DbContext
    {
        private static ApplicationContext instance;



        public static ApplicationContext getInstance()
        {
            if (instance == null)
                instance = new ApplicationContext();
            return instance;
        }
        public DbSet<Doc> docs { get; set; }
            public DbSet<Patient> patients { get; set; }
        private ApplicationContext() : base()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(
                    "server=localhost;user=root;password=root;database=shurup_project;",
                    new MySqlServerVersion(new Version(8, 0, 19))
                );
            }
        public void Save()
        {
            docs.RemoveRange(docs);
            patients.RemoveRange(patients);
            AddRange(Hospital.getInstance().a);
            AddRange(Hospital.getInstance().b);
            SaveChanges();
        }
        public void Load()
        {
            
            Hospital.getInstance().a  = docs.ToList();
            Hospital.getInstance().b = patients.ToList();

        }
    }
    }


