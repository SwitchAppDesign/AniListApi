using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaListStatus
    {
        [ExtendedDescription("Currently watching/reading")]
        [Description("CURRENT")]
        Current = 1,

        [ExtendedDescription("Planning to watch/read")]
        [Description("PLANNING")]
        Planning = 2,

        [ExtendedDescription("Finished watching/reading")]
        [Description("COMPLETED")]
        Completed = 3,

        [ExtendedDescription("Stopped watching/reading before completing")]
        [Description("DROPPED")]
        Dropped = 4,

        [ExtendedDescription("Paused watching/reading")]
        [Description("PAUSED")]
        Paused = 5
    }
}