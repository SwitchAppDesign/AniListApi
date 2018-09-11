using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available media connection query arguments.
    /// </summary>
    public class MediaConnectionQueryArguments
    {
        internal MediaConnectionQueryArguments(AniListQueryType queryType)
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
        /// The page.
        /// </summary>
        public GraphQueryArgument<int> PageQueryArgument(int value)
        {
            return Page.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The amount of entries per page, max 25.
        /// </summary>
        public GraphQueryArgument<int> PerPageQueryArgument(int value)
        {
            return PerPage.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<IEnumerable<MediaSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQueryArgument<int> Page { get; set; }
        private GraphQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Sort = new GraphQueryArgument<IEnumerable<MediaSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
            Page = new GraphQueryArgument<int>("page", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
            PerPage = new GraphQueryArgument<int>("perPage", GetType(), queryType, new QueryArgumentRules(false, 25, null, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
        }
    }
}