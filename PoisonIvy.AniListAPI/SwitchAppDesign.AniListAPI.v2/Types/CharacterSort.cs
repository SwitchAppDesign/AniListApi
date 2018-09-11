using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum CharacterSort
    {
        [Description("ID")]
        Id = 1,
        [Description("ID_DESC")]
        IdDesc = 2,
        [Description("ROLE")]
        Role = 3,
        [Description("ROLE_DESC")]
        RoleDesc = 4
    }
}
