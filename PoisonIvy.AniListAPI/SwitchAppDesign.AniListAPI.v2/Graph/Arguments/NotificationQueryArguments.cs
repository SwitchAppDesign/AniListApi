using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available notification query arguments.
    /// </summary>
    public class NotificationQueryArguments
    {
        internal NotificationQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the type of notifications.
        /// </summary>
        public GraphQueryArgument<NotificationType> TypeQueryArgument(NotificationType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Reset the unread notification count to.
        /// </summary>
        public GraphQueryArgument<bool> ResetNotificationCountQueryArgument(bool value)
        {
            return ResetNotificationCount.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<NotificationType> Type { get; set; }
        private GraphQueryArgument<bool> ResetNotificationCount { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Type = new GraphQueryArgument<NotificationType>("type", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Notification }));
            ResetNotificationCount = new GraphQueryArgument<bool>("resetNotificationCount", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Notification }));
        }
    }
}