using System.ComponentModel.DataAnnotations;

namespace CompanyMS.DTOs.ProjectDTO
{
    public class UpdateProjectDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required, Range(1000, 10000000)]
        public double Budget { get; set; }
    }
}
