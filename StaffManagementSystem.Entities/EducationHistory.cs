using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace StaffManagementSystem.Entities
{
    [Table("EducationHistory")]
    public partial class EducationHistory
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationHistoryId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(5, ErrorMessage = "Eh, pendeknya.")]
        public string Institution { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        public string CgpaGrade { get; set; }


        //--------Navigation Property-------------------------- 
        public virtual Staff Staff { get; set; }

    }
}
