using System.ComponentModel.DataAnnotations;

namespace Newsy_Job_Assignment.Models
{
    public class NewsArticle : Identity
    {
        public string? title { get; set; }
        public string? articletext { get; set; }
        public int? authorid { get; set; }
        public DateTime? publishdate { get; set; }
    }
}
