using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Med_help
{
    public class ApplicationContext : DbContext
    { 
            public DbSet<Doc> docs { get; set; }
            public DbSet<Patient> patients { get; set; }
        public ApplicationContext()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(
                    "server=localhost;user=root;password=12345678;database=usersdb5;",
                    new MySqlServerVersion(new Version(8, 0, 19))
                );
            }
        public void Save()
        {
            docs.RemoveRange(docs);
            patients.RemoveRange(patients);
            docs.AddRange(Hospital.getInstance().a);
            patients.RemoveRange(Hospital.getInstance().b);
            SaveChanges();
        }
        public void Load()
        {
            Hospital.getInstance().a  = docs.ToListAsync().Result;
            Hospital.getInstance().b = patients.ToListAsync().Result;
        }
    }
    }


