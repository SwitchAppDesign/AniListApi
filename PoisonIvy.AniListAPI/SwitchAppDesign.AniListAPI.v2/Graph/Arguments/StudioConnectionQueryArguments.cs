using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available studio connection query arguments.
    /// </summary>
    public class StudioConnectionQueryArguments
    {
        internal StudioConnectionQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<MediaSort>> SortQueryArgument(IEnumerable<MediaSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Whether the studio is the main premise.
        /// </summary>
        public GraphQueryArgument<bool> IsMainQueryArgument(bool value)
        {
            return IsMain.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<IEnumerable<MediaSort>> Sort { get; set; }
        private GraphQueryArgument<bool> IsMain { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Sort = new GraphQueryArgument<IEnumerable<MediaSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IsMain = new GraphQueryArgument<bool>("isMain", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}