using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum ThreadSort
    {
        [Description("ID")]
        Id = 1,

        [Description("ID_DESC")]
        IdDesc = 2,

        [Description("TITLE")]
        Title = 3,

        [Description("TITLE_DESC")]
        TitleDesc = 4,

        [Description("CREATED_AT")]
        CreatedAt = 5,

        [Description("CREATED_AT_DESC")]
        CreatedAtDesc = 6,

        [Description("UPDATED_AT")]
        UpdatedAt = 7,

        [Description("UPDATED_AT_DESC")]
        UpdatedAtDesc = 8,

        [Description("REPLIED_AT")]
        RepliedAt = 9,

        [Description("REPLIED_AT_DESC")]
        RepliedAtDesc = 10,

        [Description("REPLY_COUNT")]
        ReplyCount = 11,

        [Description("REPLY_COUNT_DESC")]
        ReplyCountDesc = 12,

        [Description("VIEW_COUNT")]
        ViewCount = 13,

        [Description("VIEW_COUNT_DESC")]
        ViewCountDesc = 14,

        [Description("IS_STICKY")]
        IsSticky = 15
    }
}
