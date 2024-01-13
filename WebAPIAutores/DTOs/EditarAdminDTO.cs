using System.ComponentModel.DataAnnotations;

namespace WebAPIAutores.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
