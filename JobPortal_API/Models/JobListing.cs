﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_API.Models
{
    public class JobListing
    {

        [Key]
        public int JobId { get; set; }

        [Required]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        [Required]
        [MaxLength(200)]
        public string JobDesc { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        [Required]
        public int Salary { get; set; }

    }



    }