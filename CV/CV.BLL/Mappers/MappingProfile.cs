using AutoMapper;
using CV.BLL.Models;
using CV.DAL.Entities;

namespace CV.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeModel, EmployeeEntity>().ReverseMap();

            CreateMap<ProjectModel, ProjectEntity>().ReverseMap();
        }
    }
}
