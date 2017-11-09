using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum ReviewSort
    {
        [Description("ID")]
        Id = 1,

        [Description("ID_DESC")]
        IdDesc = 2,

        [Description("SCORE")]
        Score = 3,

        [Description("SCORE_DESC")]
        ScoreDesc = 4,

        [Description("RATING")]
        Rating = 5,

        [Description("RATING_DESC")]
        RatingDesc = 6,

        [Description("CREATED_AT")]
        CreatedAt = 7,

        [Description("CREATED_AT_DESC")]
        CreatedAtDesc = 8,

        [Description("UPDATED_AT")]
        UpdatedAt = 9,

        [Description("UPDATED_AT_DESC")]
        UpdatedAtDesc = 10
    }
}