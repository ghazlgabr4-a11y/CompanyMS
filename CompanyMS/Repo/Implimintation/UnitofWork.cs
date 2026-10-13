using CompanyMS.DB;
using CompanyMS.Models;
using CompanyMS.Repo.Interface;

namespace CompanyMS.Repo.Implimintation
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
       public IGenericRepo<Department> Departments { get; }
       public IGenericRepo<Employee> Employees { get; }
      public  IGenericRepo<Project> Projects { get; }
      public  IGenericRepo<EmployeeProjects> EmployeeProjects { get; }
        public UnitofWork(AppDbContext c,IGenericRepo<Department> d, IGenericRepo<Employee> e, IGenericRepo<Project> P, IGenericRepo<EmployeeProjects> f)
        {
            _context = c;
            Departments = d;
            Employees = e;
            Projects = P;
            EmployeeProjects = f;
        }
       
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
