using AutoMapper;
using CV.BLL.Models;
using CV.BLL.Models.Skill;
using CV.DAL.Entities;
using CV.DAL.Entities.Skill;

namespace CV.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeModel, EmployeeEntity>().ReverseMap();

            CreateMap<ProjectModel, ProjectEntity>().ReverseMap();

            CreateMap<SkillModel, SkillEntity>().ReverseMap();

            CreateMap<SkillLevelModel, SkillLevelEntity>().ReverseMap();

            CreateMap<SkillGroupModel, SkillGroupEntity>().ReverseMap();
        }
    }
}
