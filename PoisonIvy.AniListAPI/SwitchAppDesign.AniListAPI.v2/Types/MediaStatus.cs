using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaStatus
    {
        [ExtendedDescription("Has completed and is no longer being released")]
        [Description("FINISHED")]
        Finished,
 
        [ExtendedDescription("Currently releasing")]
        [Description("RELEASING")]
        Releasing,

        [ExtendedDescription("To be released at a later date")]
        [Description("NOT_YET_RELEASED")]
        NotYetReleased,

        [ExtendedDescription("Ended before the work could be finished")]
        [Description("CANCELLED")]
        Cancelled
    }
}