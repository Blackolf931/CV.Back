namespace CV.API.ViewModel.SkillViewModels.Skill
{
    public class SkillViewModel
    {
        public int Id { get; set; }
#nullable disable
        public int Experience { get; set; }
        public string Name { get; set; }
        public DateTime LastUsing { get; set; }
#nullable enable
    }
}
