using System.ComponentModel.DataAnnotations;

namespace CompanyMS.DTOs.DepartmentDTO
{
    public class UpdateDepartmentDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
    }
}
