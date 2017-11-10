using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class NotificationQueryArguments
    {
        public NotificationQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the type of notifications.
        /// </summary>
        public GraphQLQueryArgument<NotificationType> TypeQueryArgument(NotificationType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Reset the unread notification count to.
        /// </summary>
        public GraphQLQueryArgument<bool> ResetNotificationCountQueryArgument(bool value)
        {
            return ResetNotificationCount.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<NotificationType> Type { get; set; }
        private GraphQLQueryArgument<bool> ResetNotificationCount { get; set; }

        private void InitializeProperties()
        {
            Type = new GraphQLQueryArgument<NotificationType>("type");
            ResetNotificationCount = new GraphQLQueryArgument<bool>("resetNotificationCount");
        }
    }
}