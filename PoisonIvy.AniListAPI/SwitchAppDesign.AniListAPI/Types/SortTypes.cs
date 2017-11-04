using System.ComponentModel;

namespace PoisonIvy.AniListAPI.Types
{
    public enum SortTypes
    {
        [Description("id")]
        Id = 0,
        [Description("score")]
        Score = 1,
        [Description("popularity")]
        Popularity = 2,
        [Description("start_date")]
        StartDate = 3,
        [Description("end_date")]
        EndDate = 4
    }
}