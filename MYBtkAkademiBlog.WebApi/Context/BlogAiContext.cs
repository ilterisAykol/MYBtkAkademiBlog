using Microsoft.EntityFrameworkCore;
using MYBtkAkademiBlog.WebApi.Entities;

namespace MYBtkAkademiBlog.WebApi.Context
{
    public class BlogAiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R286L63\\SQLEXPRESS;initial catalog=BtkAkademiAIBlogDb;integrated security=True;TrustServerCertificate=True;");
        }

        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Article> Articles { get; set; }
        public  DbSet<About> Abouts { get; set; }
        public  DbSet<Contact> Contacts { get; set; }
        public  DbSet<Employee> Employees { get; set; }
        public  DbSet<TradingVideo> TradingVideos { get; set; }
    }
}
