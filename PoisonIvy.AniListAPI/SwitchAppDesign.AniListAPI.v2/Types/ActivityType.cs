using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum ActivityType
    {
        [ExtendedDescription("A text activity")]
        [Description("TEXT")]
        Text = 1,

        [ExtendedDescription("A anime list update activity")]
        [Description("ANIME_LIST")]
        AnimeList = 2,

        [ExtendedDescription("A manga list update activity")]
        [Description("MANGA_LIST")]
        MangaList = 3,

        [ExtendedDescription("A text message activity sent to another user")]
        [Description("MESSAGE")]
        Message = 4,

        [ExtendedDescription("Anime & Manga list update, only used in query arguments")]
        [Description("MEDIA_LIST")]
        MediaList = 5
    }
}