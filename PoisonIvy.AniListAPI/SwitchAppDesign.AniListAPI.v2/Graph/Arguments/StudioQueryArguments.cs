using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class StudioQueryArguments
    {
        public StudioQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the studio id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQLQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<StudioSort>> SortQueryArgument(IEnumerable<StudioSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Whether the studio is the main studio or not.
        /// </summary>
        public GraphQLQueryArgument<bool> IsMainQueryArgument(bool value)
        {
            return IsMain.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<int> IdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<StudioSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQLQueryArgument<bool> IsMain { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            Search = new GraphQLQueryArgument<string>("search", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            IdNot = new GraphQLQueryArgument<int>("id_not", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            Sort = new GraphQLQueryArgument<IEnumerable<StudioSort>>("sort", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));

            IsMain = new GraphQLQueryArgument<bool>("isMain", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}