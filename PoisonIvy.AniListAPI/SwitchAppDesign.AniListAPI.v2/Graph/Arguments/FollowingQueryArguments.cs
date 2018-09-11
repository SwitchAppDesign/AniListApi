using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available following query arguments.
    /// </summary>
    public class FollowingQueryArguments
    {
        internal FollowingQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// User id of the follower/followed.
        /// </summary>
        public GraphQueryArgument<int?> UserIdQueryArgument(int? value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<UserSort>> SortQueryArgument(IEnumerable<UserSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int?> UserId { get; set; }
        private GraphQueryArgument<IEnumerable<UserSort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            UserId = new GraphQueryArgument<int?>("userId", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Following }));
            Sort = new GraphQueryArgument<IEnumerable<UserSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Following }));
        }
    }
}