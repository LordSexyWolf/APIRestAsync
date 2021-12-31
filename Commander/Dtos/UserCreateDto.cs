using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class UserCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string CreationDate { get; set; }

        [Required]
        public int StatusId { get; set; }
    }
}