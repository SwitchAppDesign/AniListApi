using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum StaffSort
    {
        [Description("ID")]
        Id = 1,

        [Description("ID_DESC")]
        IdDesc = 2,

        [Description("ROLE")]
        Role = 3,

        [Description("ROLE_DESC")]
        RoleDesc = 4,

        [Description("LANGUAGE")]
        Language = 5,

        [Description("LANGUAGE_DESC")]
        LanguageDesc = 6
    }
}
