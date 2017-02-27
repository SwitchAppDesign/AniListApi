using System.ComponentModel;

namespace PoisonIvy.AniListAPI.Types
{
    public enum AnimeSourceTypes
    {
        [Description("Not Found")]
        NotFound = -1,
        [Description("Original")]
        Original = 0,
        [Description("Manga")]
        Manga = 1,
        [Description("Light Novel")]
        LightNovel = 2,
        [Description("Visual Novel")]
        VisualNovel = 3,
        [Description("Video Game")]
        VideoGame = 4,
        [Description("Other")]
        Other = 5
    }
}