using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace StaffManagementSystem.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Eh, terlebih panjang pulak.")]
        [MinLength(2, ErrorMessage = "Eh, pendeknya.")]
        [Display(Name= "Department Name")]
        public string Name { get; set; }



        //--------Navigation Property-------------------------- 
        public virtual Location Location { get; set; }       
        public virtual ICollection<Staff> Staffs { get; set; } = new HashSet<Staff>();
    } 
}
