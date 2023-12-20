using Microsoft.EntityFrameworkCore;
using PustokMVC.Models;

namespace PustokMVC.Contexts
{
    public class PustokDbContext : DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> opt) : base(opt) { }

        public DbSet<HeroSlider> HeroSliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Settings> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settings>()
                .HasData(new Settings
                {
                    Address = "Baku, ",
                    Email = "cefer228@gmail.com",
                    Number1 = "+994558458202",
                    Number2 = "+994503729894",
                    Logo = "",
                    //AccountIcon = "<i class='fa fa-user-o'></i>",
                    Id = 1
                });
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-U9AO5GJ\\SQLEXPRESS;Database=PustokDB;Trusted_Connection=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
