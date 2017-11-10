using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class FollowerQueryArguments
    {
        public FollowerQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// User id of the follower/followed.
        /// </summary>
        public GraphQLQueryArgument<int?> PageQueryArgument(int? value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<UserSort>> PerPageQueryArgument(IEnumerable<UserSort> value)
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