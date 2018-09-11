using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available user query arguments.
    /// </summary>
    public class UserQueryArguments
    {
        internal UserQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the user id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the name of the user.
        /// </summary>
        public GraphQueryArgument<string> NameQueryArgument(string value)
        {
            return Name.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<UserSort>> SortQueryArgument(IEnumerable<UserSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<string> Name { get; set; }
        private GraphQueryArgument<string> Search { get; set; }
        private GraphQueryArgument<IEnumerable<UserSort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.User }));
            Name = new GraphQueryArgument<string>("name", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.User }));
            Search = new GraphQueryArgument<string>("search", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.User }));
            Sort = new GraphQueryArgument<IEnumerable<UserSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.User }));
        }
    }
}
