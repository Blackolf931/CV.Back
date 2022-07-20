using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.DAL.EF;
using CV.DAL.Entities;
using CV.DAL.Interfaces;

namespace CV.DAL.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeEntity>, IGenericRepository<EmployeeEntity>
    {
        public EmployeeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
