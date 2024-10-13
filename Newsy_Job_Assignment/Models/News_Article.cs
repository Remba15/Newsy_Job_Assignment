using System.ComponentModel.DataAnnotations;

namespace Newsy_Job_Assignment.Models
{
    public class News_Article : Identity
    {
        public string? title { get; set; }
        public string? article_text { get; set; }
        public int? author_id { get; set; }
        public DateTime? publish_date { get; set; }
    }
}
