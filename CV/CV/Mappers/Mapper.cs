using AutoMapper;
using CV.API.ViewModel.Employee;
using CV.API.ViewModel.Project;
using CV.BLL.Models;

namespace CV.API.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<EmployeeModel, EmployeeViewModel>().ReverseMap();
            CreateMap<ProjectModel, ProjectViewModel>().ReverseMap();
            CreateMap<AddEmployeeViewModel, EmployeeModel>().ReverseMap();
            CreateMap<ShortEmployeeViewModel, EmployeeModel>().ReverseMap();
            CreateMap<UpdateEmployeeViewModel, EmployeeModel>().ReverseMap();
            CreateMap<ShortEmployeeViewModel, EmployeeModel>().ReverseMap();
        }
    }
}
