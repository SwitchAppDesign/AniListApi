using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum StudioSort
    {
        [Description("ID")]
        Id = 1,

        [Description("ID_DESC")]
        IdDesc = 2,

        [Description("NAME")]
        Name = 3,

        [Description("NAME_DESC")]
        NameDesc = 4
    }
}