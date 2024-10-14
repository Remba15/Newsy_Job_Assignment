using System.ComponentModel.DataAnnotations;

namespace Newsy_Job_Assignment.Models.DTO
{
    public record NewsArticleDTOInsertUpdate(
        [Required(ErrorMessage = "Article title required")]
        string ArticleTitle,
        [Required(ErrorMessage = "Article text required")]
        string ArticleText
        );
}
