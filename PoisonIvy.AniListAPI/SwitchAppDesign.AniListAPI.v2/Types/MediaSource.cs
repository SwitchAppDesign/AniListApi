using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaSource
    {
        [ExtendedDescription("An original production not based of another work")]
        [Description("ORIGINAL")]
        Original = 1,

        [ExtendedDescription("Asian comic book")]
        [Description("MANGA")]
        Manga = 2,

        [ExtendedDescription("Written work published in volumes")]
        [Description("LIGHT_NOVEL")]
        LightNovel = 3,

        [ExtendedDescription("Video game driven primary by text and narrative")]
        [Description("VISUAL_NOVEL")]
        VisualNovel = 4,

        [ExtendedDescription("Video game")]
        [Description("VIDEO_GAME")]
        VideoGame = 5,

        [ExtendedDescription("Other")]
        [Description("OTHER")]
        Other = 6,
    }
}
