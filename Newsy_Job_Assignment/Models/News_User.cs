using System.ComponentModel.DataAnnotations.Schema;

namespace Newsy_Job_Assignment.Models
{
    public class News_User : Identity
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? email { get; set; }
        [ForeignKey("login_id")]
        public int login_id { get; set; }
        public bool author { get; set; }
        public DateTime? registration_date { get; set; }
    }
}
