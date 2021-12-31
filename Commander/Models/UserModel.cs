using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UserRolModel.Models;

namespace UserModel.Models{
    public class User{
        
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string CreationDate { get; set; }

        [Required]
        public int StatusId { get; set; }

        public int fk_id_UserRol{ get; set; }
        [ForeignKey("Id")]
        public virtual UserRol UserRolModel{ get; set; }
        
    }
}