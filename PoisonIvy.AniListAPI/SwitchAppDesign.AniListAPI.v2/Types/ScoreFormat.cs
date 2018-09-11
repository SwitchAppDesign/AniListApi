using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum ScoreFormat
    {
        [ExtendedDescription("An integer from 0-100")]
        [Description("POINT_100")]
        Point100 = 1,

        [ExtendedDescription("A float from 0-10 with 1 decimal place")]
        [Description("POINT_10_DECIMAL")]
        Point10Decimal = 2,

        [ExtendedDescription("An integer from 0-10")]
        [Description("POINT_10")]
        Point10 = 3,

        [ExtendedDescription("An integer from 0-5. Should be represented in Stars")]
        [Description("POINT_5")]
        Point5 = 4,

        [ExtendedDescription("An integer from 0-3. Should be represented in Smileys. 0 => No Score, 1 => :(, 2 => :|, 3 => :)")]
        [Description("POINT_3")]
        Point3 = 5
    }
}
