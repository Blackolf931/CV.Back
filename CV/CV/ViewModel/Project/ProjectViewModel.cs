namespace CV.API.ViewModel.Project
{
    public class ProjectViewModel
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
