using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMS.Models
{
    public class EmployeeProjects
    {
        public int Id { get; set; }
        [Required, ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required, ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        [Required,MaxLength(50)]
        public string AssignedRole { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; }
       
      


    }
}
