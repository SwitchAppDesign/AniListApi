using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaRankType
    {
        [ExtendedDescription("Ranking is based on the media's ratings/score")]
        [Description("RATED")]
        Rated = 1,

        [ExtendedDescription("Ranking is based on the media's popularity")]
        [Description("POPULAR")]
        Popular = 2
    }
}