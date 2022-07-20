namespace CV.BLL.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

#nullable disable
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }
#nullable enable
    }
}
