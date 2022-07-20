using AutoMapper;
using CV.BLL.Interfaces;
using CV.BLL.Models;
using CV.DAL.Entities;
using CV.DAL.Interfaces;

namespace CV.BLL.Services
{
    public class EmployeeServices : GenericServices<EmployeeModel, EmployeeEntity>
    {
        public EmployeeServices(IGenericRepository<EmployeeEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
