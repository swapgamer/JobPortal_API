using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_API.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        
        public DateTime ApplicationDate { get; set; }

        
        [MaxLength(50)]
        public string Status { get; set; }

        
        [ForeignKey("User")]
        public int UserId { get; set; }


        public virtual User User { get; set; }

       
        [ForeignKey("JobId")]
        public int JobId { get; set; }


        public virtual JobListing JobListing { get; set; }

       
        [MaxLength(100)]
        public string ResumeLink { get; set; }
    }
}