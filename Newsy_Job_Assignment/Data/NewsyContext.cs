using Microsoft.EntityFrameworkCore;
using Newsy_Job_Assignment.Models;

namespace Newsy_Job_Assignment.Data
{
    public class NewsyContext : DbContext
    {
        public NewsyContext(DbContextOptions<NewsyContext> options) : base(options)
        {
            
        }

        public DbSet<NewsUser> newsuser { get; set; }
        public DbSet<NewsArticle> newsarticle { get; set; }

    }
}
