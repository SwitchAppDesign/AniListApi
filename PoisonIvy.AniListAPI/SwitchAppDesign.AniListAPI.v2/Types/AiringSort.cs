using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum AiringSort
    {
        [Description("ID")]
        Id = 1,

        [Description("ID_DESC")]
        IdDesc = 2,

        [Description("MEDIA_ID")]
        MediaId = 3,

        [Description("MEDIA_ID_DESC")]
        MediaIdDesc = 4,

        [Description("TIME")]
        Time = 5,

        [Description("TIME_DESC")]
        TimeDesc = 6,

        [Description("EPISODE")]
        Episode = 7,

        [Description("EPISODE_DESC")]
        EpisodeDesc = 8
    }
}