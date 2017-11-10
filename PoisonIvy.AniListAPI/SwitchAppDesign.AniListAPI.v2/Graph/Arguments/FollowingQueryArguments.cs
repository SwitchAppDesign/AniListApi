using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class FollowingQueryArguments
    {
        public FollowingQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// User id of the follower/followed.
        /// </summary>
        public GraphQLQueryArgument<int?> UserIdQueryArgument(int? value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<UserSort>> SortQueryArgument(IEnumerable<UserSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int?> UserId { get; set; }
        private GraphQLQueryArgument<IEnumerable<UserSort>> Sort { get; set; }

        private void InitializeProperties()
        {
            UserId = new GraphQLQueryArgument<int?>("userId");
            Sort = new GraphQLQueryArgument<IEnumerable<UserSort>>("sort");
        }
    }
}