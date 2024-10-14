namespace Newsy_Job_Assignment.Models.DTO
{
    public record NewsUserDTORead(
        int Id,
        string Name,
        string Surname,
        string Email,
        bool? Author,
        DateTime? RegistrationDate
        );
    
}
