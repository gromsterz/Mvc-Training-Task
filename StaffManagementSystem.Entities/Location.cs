using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.Entities
{
    [Table("Location")]
    public class Location
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        [Required] 
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        [Display(Name = "Location Name")]
        public string Name { get; set; }


        //--------Navigation Property--------------------------
        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();
    } 
}
