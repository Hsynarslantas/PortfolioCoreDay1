using Microsoft.EntityFrameworkCore;
using PortofolioCoreDay.Entities;

namespace PortofolioCoreDay.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O65VQEH\\SQLEXPRESS;initial Catalog=PortfolioDayDb3;integrated security = true;trust server certificate = true");
        }
        public DbSet<Education> Educations { get; set; }

        public DbSet<Experience>Experiences  { get; set; }

        public DbSet<Message>Messages{ get; set; }

        public DbSet<Service> Services{ get; set; }

        public DbSet<Testimonial>Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
