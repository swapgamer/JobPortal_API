using System.ComponentModel.DataAnnotations;

namespace JobPortal_API.BLL.DTO
{
    public class UserRoleDTO
    {
        [Key]
        public int UserRoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserRoleName { get; set; }
    }
}
