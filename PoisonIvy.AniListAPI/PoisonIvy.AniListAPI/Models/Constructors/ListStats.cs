using PoisonIvy.Models.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class ListStats
    {
        public static ListStats ConstructFromDto(ListStatsDTO dto)
        {
            return new ListStats()
            {
                PlanToWatch = dto.plan_to_watch,
                Watching = dto.watching,
                Completed = dto.completed,
                OnHold = dto.on_hold,
                Dropped = dto.dropped
            };
        }
    }
}
