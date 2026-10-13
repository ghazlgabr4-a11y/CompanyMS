using System.ComponentModel.DataAnnotations;

namespace CompanyMS.DTOs.EmployeeDTO
{
    public class GetEmployeeDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Range(3000, 100000)]
        public double Salary { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
    }
}
