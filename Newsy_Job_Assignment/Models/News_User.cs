using System.ComponentModel.DataAnnotations;

namespace Newsy_Job_Assignment.Models
{
    public class News_User : Identity
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? email { get; set; }
        public bool author { get; set; }
        public DateTime? registration_date { get; set; }
    }
}
