using CV.DAL.Infraestructure;

namespace CV.DAL.Entities
{
    public class SkillEntity : HasId
    {
#nullable disable
        public int Experience { get; set; }
        public string Name { get; set; }
        public DateTime LastUsing { get; set; }
#nullable enable
    }
}
