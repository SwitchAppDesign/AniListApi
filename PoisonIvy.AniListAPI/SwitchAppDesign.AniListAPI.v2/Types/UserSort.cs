using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum UserSort
    {
        [Description("ID")]
        Id = 1,

        [Description("ID_DESC")]
        IdDesc = 2,

        [Description("USERNAME")]
        Username = 3,

        [Description("USERNAME_DESC")]
        UsernameDesc = 4,

        [Description("WATCHED_TIME")]
        WatchedTime = 5,

        [Description("WATCHED_TIME_DESC")]
        WatchedTimeDesc = 6,

        [Description("CHAPTERS_READ")]
        ChaptersRead = 7,

        [Description("CHAPTERS_READ_DESC")]
        ChaptersReadDesc = 8
    }
}