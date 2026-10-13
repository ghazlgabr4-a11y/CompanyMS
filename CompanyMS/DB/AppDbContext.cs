using CompanyMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyMS.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProjects> EmployeeProjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Departmentt)
                .HasForeignKey(e => e.DepartmetId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Projects)
                .WithOne(p => p.Departmentt)
                .HasForeignKey(p => p.DepartmetId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<EmployeeProjects>()
                .HasOne(o=>o.Employee)
                .WithMany(e => e.EmplProjects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeProjects>()
                .HasOne(p => p.Project)
                .WithMany(p => p.EmplProjects)
                .HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Department>().HasData
                (
                new Department { Id = 1, Name = "Human Resources", Location = "New York" },
                new Department { Id = 2, Name = "IT", Location = "San Francisco" },
                new Department { Id = 3, Name = "Finance", Location = "Chicago" }
                );

            modelBuilder.Entity<Employee>().HasData
                (
                 new Employee
                 {
                     Id = 1,
                     Name = "John Doe",
                     Email = "JO3H_K@gmail.com",
                     Salary = 5000,
                     HireDate = DateTime.Now,
                     DepartmetId = 1,
                 },
                 new Employee
                 {
                     Id = 2,
                     Name = "Jane Smith",
                     Email = "J223@mail.com",
                     Salary = 6000,
                     HireDate = DateTime.Now,
                     DepartmetId = 2,
                 },
                 new Employee
                 {
                     Id = 3,
                     Name = "Bob Johnson",
                     Email = "btroi@gmail.com",
                     Salary = 7000,
                     HireDate = DateTime.Now,
                     DepartmetId = 3,
                 }
                );

            modelBuilder.Entity<Project>().HasData
                (
                    new Project
                    {
                        Id = 1,
                        Name = "Project A",
                        Description = "Description for Project A",
                        StartDate = DateTime.Now,
                        Budget = 10000,
                        DepartmetId = 1,
                     
                    },
                    new Project
                    {
                        Id = 2,
                        Name = "Project B",
                        Description = "Description for Project B",
                        StartDate = DateTime.Now,
                        Budget = 20000,
                        DepartmetId = 2,
                    
                    },
                    new Project
                    {
                        Id = 3,
                        Name = "Project C",
                        Description = "Description for Project C",
                        StartDate = DateTime.Now,
                        Budget = 30000,
                        DepartmetId = 3,
                     
                    }
                );
            modelBuilder.Entity<EmployeeProjects>().HasData
                (
                new EmployeeProjects { Id = 1, EmployeeId = 1, ProjectId = 1, AssignedRole = "Developer", AssignedDate = DateTime.Now },
                new EmployeeProjects { Id = 2, EmployeeId = 2, ProjectId = 2, AssignedRole = "Tester", AssignedDate = DateTime.Now },
                new EmployeeProjects { Id = 3, EmployeeId = 3, ProjectId = 3, AssignedRole = "Manager", AssignedDate = DateTime.Now }
                );


        }
    }
}
