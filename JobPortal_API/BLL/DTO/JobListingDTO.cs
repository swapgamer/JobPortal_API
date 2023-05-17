using JobPortal_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_API.BLL.DTO
{
    public class JobListingDTO
    {
        
        public int JobId { get; set; }

      
        public string JobTitle { get; set; }

       
        public string JobDesc { get; set; }

    
        public DateTime DatePosted { get; set; }

      
        
        public virtual UserDTO User { get; set; }

       
        public string CompanyName { get; set; }

       
        public int Salary { get; set; }
    }
}
