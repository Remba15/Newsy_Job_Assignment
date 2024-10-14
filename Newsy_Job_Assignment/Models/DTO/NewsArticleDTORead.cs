namespace Newsy_Job_Assignment.Models.DTO
{
    public record NewsArticleDTORead(
        int id,
        string articletitle,
        string articletext,
        int authorid,
        DateTime? publishdate
        );
}
