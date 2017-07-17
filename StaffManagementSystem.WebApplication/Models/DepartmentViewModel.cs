using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.WebApplication.Models
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }
    }
}