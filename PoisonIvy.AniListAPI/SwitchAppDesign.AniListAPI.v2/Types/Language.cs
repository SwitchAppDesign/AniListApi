using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum Language
    {
        [ExtendedDescription("Japanese")]
        [Description("JAPANESE")]
        Japanese = 1,

        [ExtendedDescription("English")]
        [Description("ENGLISH")]
        English = 2,

        [ExtendedDescription("Korean")]
        [Description("KOREAN")]
        Korean = 3,

        [ExtendedDescription("Italian")]
        [Description("ITALIAN")]
        Italian = 4,

        [ExtendedDescription("Spanish")]
        [Description("SPANISH")]
        Spanish = 5,

        [ExtendedDescription("Portuguese")]
        [Description("PORTUGUESE")]
        Portuguese = 6,
 
        [ExtendedDescription("French")]
        [Description("FRENCH")]
        French = 7,
 
        [ExtendedDescription("German")]
        [Description("GERMAN")]
        German = 8,
 
        [ExtendedDescription("Hebrew")]
        [Description("HEBREW")]
        Hebrew = 9,

        [ExtendedDescription("Hungarian")]
        [Description("HUNGARIAN")]
        Hungarian = 10
    }
}
