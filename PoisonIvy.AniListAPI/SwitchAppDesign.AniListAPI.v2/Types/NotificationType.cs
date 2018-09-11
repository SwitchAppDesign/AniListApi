using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum NotificationType
    {
        [ExtendedDescription("A user has sent you message")]
        [Description("ACTIVITY_MESSAGE")]
        ActivityMessage = 1,

        [ExtendedDescription("A user has replied to your activity")]
        [Description("ACTIVITY_REPLY")]
        ActivityReply = 2,

        [ExtendedDescription("A user has followed you")]
        [Description("FOLLOWING")]
        Following = 3,

        [ExtendedDescription("A user has mentioned you in their activity")]
        [Description("ACTIVITY_MENTION")]
        ActivityMention = 4,

        [ExtendedDescription("A user has mentioned you in a forum comment")]
        [Description("THREAD_COMMENT_MENTION")]
        ThreadCommentMention = 5,

        [ExtendedDescription("A user has commented in one of your subscribed forum threads")]
        [Description("THREAD_SUBSCRIBED")]
        ThreadSubscribed = 6,

        [ExtendedDescription("A user has replied to your forum comment")]
        [Description("THREAD_COMMENT_REPLY")]
        ThreadCommentReply = 7,

        [ExtendedDescription("An anime you are currently watching has aired")]
        [Description("AIRING")]
        Airing = 8,

        [ExtendedDescription("A user has liked your activity")]
        [Description("ACTIVITY_LIKE")]
        ActivityLike = 9,

        [ExtendedDescription("A user has liked your activity reply")]
        [Description("ACTIVITY_REPLY_LIKE")]
        ActivityReplyLike = 10,

        [ExtendedDescription("A user has liked your forum thread")]
        [Description("THREAD_LIKE")]
        ThreadLike = 11,

        [ExtendedDescription("A user has liked your forum comment")]
        [Description("THREAD_COMMENT_LIKE")]
        ThreadCommentLike = 12
    }
}