using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.BLL.Models.Skill
{
    public class SkillModel
    {
        public int Id { get; set; }

#nullable disable
        public int Experience { get; set; }
        public string Name { get; set; }
        public DateTime LastUsing { get; set; }
#nullable enable
    }
}
