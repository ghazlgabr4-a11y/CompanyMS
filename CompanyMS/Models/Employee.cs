using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMS.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required,Range(3000,100000)]
        public double Salary { get; set; }
        [Required]
        public DateTime HireDate { get; set; }  
        [Required,ForeignKey(nameof(Departmentt))]
        public int DepartmetId { get; set; }
        public Department Departmentt { get; set; }
        public ICollection<EmployeeProjects> EmplProjects { get; set; } = new List<EmployeeProjects>();   
    }
}
