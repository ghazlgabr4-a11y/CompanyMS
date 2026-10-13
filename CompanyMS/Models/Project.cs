using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CompanyMS.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string ?Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required,Range(1000,10000000)]
        public double Budget { get; set; }
        [Required, ForeignKey(nameof(Departmentt))]
        public int DepartmetId { get; set; }
        public Department Departmentt { get; set; }
       public ICollection<EmployeeProjects> EmplProjects { get; set; } = new List<EmployeeProjects>();

    }
}
