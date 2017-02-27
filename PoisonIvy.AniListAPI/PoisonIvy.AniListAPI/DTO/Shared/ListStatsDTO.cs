namespace PoisonIvy.Models.DTO
{
    public class ListStatsDTO
    {
        public long plan_to_watch { get; set; }
        public long watching { get; set; }
        public long completed { get; set; }
        public long on_hold { get; set; }
        public long dropped { get; set; }
    }
}
