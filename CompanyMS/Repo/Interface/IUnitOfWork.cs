using CompanyMS.Models;

namespace CompanyMS.Repo.Interface
{
    public interface IUnitOfWork
    {
        IGenericRepo<Department> Departments { get; }
        IGenericRepo<Employee> Employees { get; }
        IGenericRepo<Project> Projects { get; }
        IGenericRepo<EmployeeProjects> EmployeeProjects { get; }
        Task SaveAsync();
    }
}
