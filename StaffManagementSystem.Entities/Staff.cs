using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.Entities
{
    //By default, tables name will use class name as plural
    [Table("Staff")]
    public class Staff
    {
        [Key, Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int StaffId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        public string Lastname { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(8, ErrorMessage = "Eh, pendeknya.")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [MaxLength(10, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(4, ErrorMessage = "Eh, pendeknya.")]
        public string Gender { get; set; }

        [Required]
        [MaxLength(5000, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(4, ErrorMessage = "Eh, pendeknya.")]
        public string Address { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        public string FullName
        {
            get
            {              
                return $"{FirstName} {Lastname}";
            }
        }

        [NotMapped]
        [ScaffoldColumn(false)]
        public int Age {
            get {
                DateTime now = DateTime.Today;
                int age = now.Year - DateOfBirth.Year;
                return age;
            } 
        }
        
        [Required]
        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; } = DateTime.Now;

         //--------Navigation Property--------------------------
        public virtual Department Department { get; set; }
        public virtual StaffRole StaffRole { get; set; }
        public virtual ICollection<EducationHistory> EducationHistories { get; set; } = new HashSet<EducationHistory>();
        public virtual ICollection<WorkingHistory> WorkingHistories { get; set; } = new HashSet<WorkingHistory>();
    }


}
