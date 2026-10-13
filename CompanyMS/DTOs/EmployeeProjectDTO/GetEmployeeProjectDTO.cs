using CompanyMS.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CompanyMS.DTOs.EmployeeProjectDTO
{
    public class GetEmployeeProjectDTO
    {
        public int Id { get; set; }
        [Required, ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required, ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        [Required, MaxLength(50)]
        public string AssignedRole { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; }
    }
}
