using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaType
    {
        [Description("ANIME")]
        Anime = 1,
        [Description("MANGA")]
        Manga = 2
    }
}