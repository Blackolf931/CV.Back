using AutoMapper;
using CV.API.ViewModel.Project;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProjectController : GenericController<ProjectViewModel, ShortProjectViewModel, AddProjectViewModel, ProjectModel, UpdateProjectViewModel>
    {
        public ProjectController(IGenericServices<ProjectModel> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
