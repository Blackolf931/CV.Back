using CV.DAL.Infraestructure;

namespace CV.DAL.Entities
{
    public class EmployeeEntity : HasId
    {
#nullable disable
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
#nullable enable
    }
}
