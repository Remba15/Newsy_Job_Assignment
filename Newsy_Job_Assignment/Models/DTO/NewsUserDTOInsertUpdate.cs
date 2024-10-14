using System.ComponentModel.DataAnnotations;

namespace Newsy_Job_Assignment.Models.DTO
{
    public record NewsUserDTOInsertUpdate(
        [Required(ErrorMessage = "Name required")]
        string Name,
        [Required(ErrorMessage = "Surname required")]
        string Surname,
        [Required(ErrorMessage = "Email address required")]
        string Email,
        bool? Author,
        DateTime? RegistrationDate
        );
    
}
