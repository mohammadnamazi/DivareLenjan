using DataAccessLayer.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class DivarContext : DbContext
    {
        public DivarContext(DbContextOptions<DivarContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Gallary> Gallaries { get; set; }
        public DbSet<AdvertField> AdvertFields { get; set; }
        public DbSet<CategoryField> CategoryFields { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
