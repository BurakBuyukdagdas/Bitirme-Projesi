using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=94.73.146.5;database=u1400114_CvDb;user=u1400114_BurakBu;password=9:_C_T.Hlwif46K9");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
