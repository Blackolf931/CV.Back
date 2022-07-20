using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.BLL.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }

#nullable disable
        public string Name { get; set; }

        public TimeZoneInfo StartProject { get; set; }

        public TimeZoneInfo EndProject { get; set; }

        public string Description { get; set; }

        public string Environment { get; set; }
#nullable enable
    }
}
