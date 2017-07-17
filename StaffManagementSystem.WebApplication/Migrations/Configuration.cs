using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace StaffManagementSystem.WebApplication.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext.ApplicationDbContext context)
        {
            var blockADepartments = new List<Entities.Department>()
            {
                new Entities.Department(){Name= "Technology Infrastructure"},
                new Entities.Department(){Name= "Networking"},
                new Entities.Department(){Name= "Security"},
            };
            var blockBDepartments = new List<Entities.Department>()
            {
                new Entities.Department(){Name= "Finance"},
                new Entities.Department(){Name= "Accounting"},
                new Entities.Department(){Name= "Customer Service"},
            };
            var blockCDepartments = new List<Entities.Department>()
            {
                new Entities.Department(){Name= "Chemical"},
                new Entities.Department(){Name= "Substances"},
                new Entities.Department(){Name= "Reaction"},
            };

            context.Locations.AddOrUpdate(l => l.Name,
                new Entities.Location() { Name = "Block A",Departments = blockADepartments },
                new Entities.Location() { Name = "Block B", Departments = blockBDepartments },
                new Entities.Location() { Name = "Block C", Departments = blockCDepartments },
                new Entities.Location() { Name = "Block D" });
        }
    }
}
