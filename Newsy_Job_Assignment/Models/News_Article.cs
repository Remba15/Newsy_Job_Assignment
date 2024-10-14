using System.ComponentModel.DataAnnotations.Schema;

namespace Newsy_Job_Assignment.Models
{
    public class News_Article : Identity
    {
        public string? title { get; set; }
        public string? article_text { get; set; }
        [ForeignKey("author_id")]
        public required int? author_id { get; set; }
        public DateTime? publish_date { get; set; }
    }
}
