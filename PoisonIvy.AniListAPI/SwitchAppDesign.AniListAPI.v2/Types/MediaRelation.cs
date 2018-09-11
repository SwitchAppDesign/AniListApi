using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaRelation
    {
        [ExtendedDescription("An adaption of the media into a different format")]
        [Description("ADAPTATION")]
        Adaptation = 1,

        [ExtendedDescription("Released before the relation")]
        [Description("PREQUEL")]
        Prequel = 2,

        [ExtendedDescription("Released after the relation")]
        [Description("SEQUEL")]
        Sequel = 3,

        [ExtendedDescription("The media a side story is from")]
        [Description("PARENT")]
        Parent = 4,

        [ExtendedDescription("A side story of the parent media")]
        [Description("SIDE_STORY")]
        SideStory = 5,

        [ExtendedDescription("Shares at least 1 character")]
        [Description("CHARACTER")]
        Character = 6,

        [ExtendedDescription("A shortened and summarized version")]
        [Description("SUMMARY")]
        Summary = 7,

        [ExtendedDescription("An alternative version of the same media")]
        [Description("ALTERNATIVE")]
        Alternative = 8,

        [ExtendedDescription("An alternative version of the media with a different primary focus")]
        [Description("SPIN_OFF")]
        SpinOff = 9,

        [ExtendedDescription("Other")]
        [Description("OTHER")]
        Other = 10
    }
}
