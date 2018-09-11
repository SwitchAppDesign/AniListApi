using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum ReviewRating
    {
        [Description("NO_VOTE")]
        NoVote = 1,
        [Description("UP_VOTE")]
        UpVote = 2,
        [Description("DOWN_VOTE")]
        DownVote = 3
    }
}