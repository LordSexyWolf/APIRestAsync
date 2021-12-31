using System.ComponentModel.DataAnnotations;

namespace UserRolModel.Models{
    public class UserRolReadDto{
        
        
        public int Id { get; set; }
       
        public int UserId { get; set; }
        
        public int RoleId { get; set; }

        public int StatusId { get; set; }

    }
}