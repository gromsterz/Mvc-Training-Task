using System;
using System.ComponentModel.DataAnnotations;

namespace StaffManagementSystem.WebApplication.Models
{
    public class StaffViewModel
    {
    
        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        public string Lastname { get; set; }

        [Required]
        public DateTime Dob { get; set; } = DateTime.Now;

        [Required]
        public string Department { get; set; } 
    }
}