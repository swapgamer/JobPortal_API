using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_API.Models
{
    public class User
    {
       

            [Key]
            public int UserId { get; set; }

            [Required]
            [MaxLength(50)]
            public string UserName { get; set; }

            [Required]
            [MaxLength(50)]
            public string Email { get; set; }

            [Required]
            [MaxLength(50)]
            public string Password { get; set; }

            [Required]
            [MaxLength(50)]
            public string FName { get; set; }

            [Required]
            [MaxLength(50)]
            public string LName { get; set; }

            [Required]
            [ForeignKey("UserRole")]
            public int UserRoleId { get; set; }
            public virtual UserRole UserRole { get; set; }
        }
}