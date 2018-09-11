using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available activity reply query arguments.
    /// </summary>
    public class ActivityReplyQueryArguments
    {
        internal ActivityReplyQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the reply id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the parent id.
        /// </summary>
        public GraphQueryArgument<int> ActivityIdQueryArgument(int value)
        {
            return ActivityId.GetQueryArgumentAndSetValue(value);
        }


        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> ActivityId { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
            ActivityId = new GraphQueryArgument<int>("activityId", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
        }
    }
}