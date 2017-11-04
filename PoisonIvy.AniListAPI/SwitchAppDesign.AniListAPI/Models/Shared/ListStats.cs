namespace PoisonIvy.AniListAPI.Models
{
    public partial class ListStats
    {
        public long PlanToWatch { get; set; }
        public long Watching { get; set; }
        public long Completed { get; set; }
        public long OnHold { get; set; }
        public long Dropped { get; set; }
    }
}
