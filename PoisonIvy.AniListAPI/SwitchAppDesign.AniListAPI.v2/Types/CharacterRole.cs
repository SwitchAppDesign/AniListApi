using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum CharacterRole
    {
        [ExtendedDescription(" A primary character role in the media")]
        [Description("MAIN")]
        Main = 1,

        [ExtendedDescription(" A supporting character role in the media")]
        [Description("SUPPORTING")]
        Supporting = 2,

        [ExtendedDescription(" A background character in the media")]
        [Description("BACKGROUND")]
        Background = 3
    }
}
