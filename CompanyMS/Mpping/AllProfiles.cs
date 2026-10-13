using AutoMapper;
using CompanyMS.DTOs.DepartmentDTO;
using CompanyMS.DTOs.EmployeeDTO;
using CompanyMS.DTOs.EmployeeProjectDTO;
using CompanyMS.DTOs.ProjectDTO;
using CompanyMS.Models;

namespace CompanyMS.Mpping
{
    public class AllProfiles:Profile
    {
        public AllProfiles()
        {
            CreateMap<GetEmployeeDTO, Employee>();
            CreateMap<CreateEmployeeDTO, Employee>();
            CreateMap<UpdateEmplyeeDTO, Employee>();

            CreateMap<GetDepartmentDTO, Department>();
            CreateMap<CreateDepartmentDTO, Department>();
            CreateMap<UpdateDepartmentDTO, Department>();

            CreateMap<CreateProjectDTO, Project>();
            CreateMap<UpdateProjectDTO, Project>();
            CreateMap<GetDepartmentDTO, Department>();

            CreateMap<CreateEmployeeProjectDTO, Project>();
            CreateMap<UpdateEmployeeProjectDTO, Project>();
            CreateMap<GetEmployeeProjectDTO, Project>();
           


        }

    }
}
