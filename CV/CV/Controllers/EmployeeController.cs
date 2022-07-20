using AutoMapper;
using CV.API.ViewModel.Employee;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : GenericController<EmployeeViewModel, ShortEmployeeViewModel, AddEmployeeViewModel, EmployeeModel, UpdateEmployeeViewModel>
    {
        public EmployeeController(IEmployeeService<EmployeeModel> employeeService, IMapper mapper) : base(employeeService, mapper)
        {
        }
    }
}
