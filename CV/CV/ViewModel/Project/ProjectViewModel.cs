namespace CV.API.ViewModel.Project
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

#nullable disable
        public string Name { get; set; }

        public DateTime StartProject { get; set; }

        public string Description { get; set; }

        public string Environment { get; set; }
#nullable enable

        public DateTime? EndProject { get; set; }
    }
}
