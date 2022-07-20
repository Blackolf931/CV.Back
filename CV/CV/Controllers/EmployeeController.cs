using AutoMapper;
using CV.API.ViewModel.Employee;
using CV.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : GenericController<EmployeeViewModel, ShortEmployeeViewModel, AddEmployeeViewModel, EmployeeModel, UpdateEmployeeViewModel>
    {
        public EmployeeController(IGenericServices<EmployeeModel> genericService, IMapper mapper) : base(genericService, mapper)
        {

        }
    }
}
