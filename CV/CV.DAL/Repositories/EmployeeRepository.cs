using CV.DAL.EF;
using CV.DAL.Entities;

namespace CV.DAL.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeEntity>
    {
        public EmployeeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
