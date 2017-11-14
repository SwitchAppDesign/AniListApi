using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available studio query arguments.
    /// </summary>
    public class StudioQueryArguments
    {
        internal StudioQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the studio id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<StudioSort>> SortQueryArgument(IEnumerable<StudioSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Whether the studio is the main studio or not.
        /// </summary>
        public GraphQueryArgument<bool> IsMainQueryArgument(bool value)
        {
            return IsMain.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<string> Search { get; set; }
        private GraphQueryArgument<int> IdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQueryArgument<IEnumerable<StudioSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQueryArgument<bool> IsMain { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            Search = new GraphQueryArgument<string>("search", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            IdNot = new GraphQueryArgument<int>("id_not", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            IdIn = new GraphQueryArgument<IEnumerable<int>>("id_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            IdNotIn = new GraphQueryArgument<IEnumerable<int>>("id_not_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));
            Sort = new GraphQueryArgument<IEnumerable<StudioSort>>("sort", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Studio }));

            IsMain = new GraphQueryArgument<bool>("isMain", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}