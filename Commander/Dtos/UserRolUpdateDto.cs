using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class UserRolUpdateDto
    {
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public int RoleId { get; set; }

        [Required]
        public int StatusId { get; set; }
    }
}