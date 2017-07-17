using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.Entities
{
    [Table("StaffRole")]
    public class StaffRole
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffRoleId { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(4, ErrorMessage = "Eh, pendeknya.")]
        public string Name { get; set; }


        //--------Navigation Property--------------------------
        public virtual ICollection<Staff> Staffs { get; set; } = new HashSet<Staff>();
    }
}
