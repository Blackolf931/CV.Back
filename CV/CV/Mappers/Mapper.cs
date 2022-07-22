using AutoMapper;
using CV.API.ViewModel.Employee;
using CV.API.ViewModel.Project;
using CV.API.ViewModel.SkillViewModels.Skill;
using CV.API.ViewModel.SkillViewModels.SkillGroup;
using CV.API.ViewModel.SkillViewModels.SkillLevel;
using CV.BLL.Models;
using CV.BLL.Models.Skill;

namespace CV.API.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<EmployeeModel, EmployeeViewModel>().ReverseMap();
            CreateMap<AddEmployeeViewModel, EmployeeModel>().ReverseMap();
            CreateMap<ShortEmployeeViewModel, EmployeeModel>().ReverseMap();
            CreateMap<UpdateEmployeeViewModel, EmployeeModel>().ReverseMap();
            
            CreateMap<ProjectModel, ProjectViewModel>().ReverseMap();
            CreateMap<AddProjectViewModel, ProjectModel>().ReverseMap();
            CreateMap<ShortProjectViewModel, ProjectModel>().ReverseMap();
            CreateMap<UpdateProjectViewModel, ProjectModel>().ReverseMap();
            
            CreateMap<SkillViewModel, SkillModel>().ReverseMap();
            CreateMap<AddSkillViewModel, SkillModel>().ReverseMap();
            CreateMap<ShortSkillViewModel, SkillModel>().ReverseMap();
            CreateMap<UpdateSkillViewModel, SkillModel>().ReverseMap();
            
            CreateMap<SkillGroupViewModel, SkillGroupModel>().ReverseMap();
            CreateMap<AddSkillGroupViewModel, SkillGroupModel>().ReverseMap();
            CreateMap<ShortSkillGroupViewModel, SkillGroupModel>().ReverseMap();
            CreateMap<UpdateSkillGroupViewModel, SkillGroupModel>().ReverseMap();
            
            CreateMap<SkillLevelViewModel, SkillLevelModel>().ReverseMap();
            CreateMap<AddSkillLevelViewModel, SkillLevelModel>().ReverseMap();
            CreateMap<ShortSkillLevelViewModel, SkillLevelModel>().ReverseMap();
            CreateMap<UpdateSkillLevelViewModel, SkillLevelModel>().ReverseMap();
        }
    }
}
