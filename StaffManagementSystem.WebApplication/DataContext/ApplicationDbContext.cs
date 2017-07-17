using Microsoft.AspNet.Identity.EntityFramework;
using StaffManagementSystem.WebApplication.Models;
using System.Data.Entity;
using StaffManagementSystem.Entities;

namespace StaffManagementSystem.WebApplication.DataContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<EducationHistory> EducationHistories { get; set; }
        public DbSet<WorkingHistory> WorkingHistories { get; set; }
        public DbSet<StaffRole> StaffRoles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //From the database diagram, see how many relationship that we have.
            //In this case we have 5 relationships, thus we should have 5 lines of code like down below:

            //1. A Department has one location, A Location has many Departments           
            modelBuilder.Entity<Department>().HasRequired(s => s.Location).WithMany(d => d.Departments).Map(m=>m.MapKey("LocationId")).WillCascadeOnDelete(true);
            //By default foreignKey will be TargetClass_TargetClassId eg = Location_LocationId
            //Map Api will override the default convention and only use LocationId

            //2. A Staff has one Department, A Department has many Staffs 
            modelBuilder.Entity<Staff>().HasRequired(s => s.Department).WithMany(d => d.Staffs).Map(m => m.MapKey("DepartmentId")).WillCascadeOnDelete(true);

            //3. A Staff has one Role, A Role has many Staffs 
            modelBuilder.Entity<Staff>().HasRequired(s => s.StaffRole).WithMany(d => d.Staffs).Map(m => m.MapKey("StaffRoleId")).WillCascadeOnDelete(true);

            //4. A Staff has many WorkingHistory
            modelBuilder.Entity<Staff>().HasMany(s => s.WorkingHistories).WithRequired(x => x.Staff).Map(m => m.MapKey("StaffId"));

            //5. A Staff has many EducationHistory
            modelBuilder.Entity<Staff>().HasMany(s => s.EducationHistories).WithRequired(x => x.Staff).Map(m => m.MapKey("StaffId")); ;

            base.OnModelCreating(modelBuilder);
        }
    }
}