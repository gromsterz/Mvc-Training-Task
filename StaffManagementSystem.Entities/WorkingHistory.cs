using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.Entities
{
    [Table("WorkingHistory")]
    public class WorkingHistory
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkingHistoryId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(4, ErrorMessage = "Eh, pendeknya.")]
        public string Company { get; set; }

        [Required]
        [Display(Name  = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [MaxLength(1000)]
        public string CompanyWebsiteLink { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(4, ErrorMessage = "Eh, pendeknya.")]
        public string Position { get; set; }

        [MaxLength(5000, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(4, ErrorMessage = "Eh, pendeknya.")]
        public string PositionDescription { get; set; }

        //--------Navigation Property-------------------------- 
        public virtual Staff Staff { get; set; }
    }
}
