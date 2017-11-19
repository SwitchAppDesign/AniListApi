using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available follower query arguments.
    /// </summary>
    public class FollowerQueryArguments
    {
        internal FollowerQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// User id of the follower/followed.
        /// </summary>
        public GraphQueryArgument<int?> PageQueryArgument(int? value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<UserSort>> PerPageQueryArgument(IEnumerable<UserSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int?> UserId { get; set; }
        private GraphQueryArgument<IEnumerable<UserSort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            UserId = new GraphQueryArgument<int?>("userId", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Follower }));
            Sort = new GraphQueryArgument<IEnumerable<UserSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Follower }));
        }
    }
}