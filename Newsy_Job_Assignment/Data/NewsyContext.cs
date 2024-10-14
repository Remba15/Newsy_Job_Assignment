using Microsoft.EntityFrameworkCore;
using Newsy_Job_Assignment.Models;

namespace Newsy_Job_Assignment.Data
{
    public class NewsyContext : DbContext
    {
        public NewsyContext(DbContextOptions<NewsyContext> options) : base(options)
        {
            
        }

        public DbSet<News_User> news_user { get; set; }
        public DbSet<News_Article> news_article { get; set; }
        public DbSet<Login> login { get; set; }

    }
}
