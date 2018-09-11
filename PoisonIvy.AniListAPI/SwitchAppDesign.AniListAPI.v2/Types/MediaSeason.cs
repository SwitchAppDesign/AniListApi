using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaSeason
    { 
        [ExtendedDescription("Months December to February")]
        [Description("WINTER")]
        Winter = 1,
        [ExtendedDescription("Months March to May")]
        [Description("SPRING")]
        Spring = 2,
        [ExtendedDescription("Months June to August")]
        [Description("SUMMER")]
        Summer = 3,
        [ExtendedDescription("Months September to November")]
        [Description("FALL")]
        Fall = 4
    }
}
