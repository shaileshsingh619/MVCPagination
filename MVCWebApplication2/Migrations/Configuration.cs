namespace MVCWebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVCWebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCWebApplication2.Models.EmployeeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCWebApplication2.Models.EmployeeDBContext";
        }

        protected override void Seed(MVCWebApplication2.Models.EmployeeDBContext context)
        {
                context.Employees.AddOrUpdate(i => i.Name,

                new Employee
                {
                    Name = "Ralph",
                    Sirname = "Ray",
                    Age = "25",
                    Designation = "Developer",
                    DOJ = DateTime.Parse("2010-04-07")
                },

                new Employee
                {
                    Name = "Leo",
                    Sirname = "abc",
                    Age = "26",
                    Designation = "RST",
                    DOJ = DateTime.Parse("2010-04-07")
                },

                new Employee
                {
                    Name = "Sheldon",
                    Sirname = "Cooper",
                    Age = "45",
                    Designation = "Director",
                    DOJ = DateTime.Parse("2012-1-11")
                },

                 new Employee
                 {
                     Name = "Raj ",
                     Sirname = "Kutrapali",
                     Age = "35",
                     Designation = "Developer",
                     DOJ = DateTime.Parse("2011-9-17")
                 },

                 new Employee
                 {
                     Name = "Penny",
                     Sirname = "Nabraska",
                     Age = "30",
                     Designation = "Manager",
                     DOJ = DateTime.Parse("2017-10-11")
                 },

               new Employee
               {
                   Name = "Lenord",
                   Sirname = "Hofstedder",
                   Age = "42",
                   Designation = "Producer",
                   DOJ = DateTime.Parse("2018-04-07")
               }
           );
        }
    }
}
