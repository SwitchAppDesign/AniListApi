using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available media connection query arguments.
    /// </summary>
    public class AiringScheduleConnectionQueryArguments
    {
        internal AiringScheduleConnectionQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<bool> NotYetAiredQueryArgument(bool value)
        {
            return NotYetAired.GetQueryArgumentAndSetValue(value);
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

        private GraphQueryArgument<bool> NotYetAired { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQueryArgument<int> Page { get; set; }
        private GraphQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            NotYetAired = new GraphQueryArgument<bool>("notYetAired", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> {  AniListQueryType.Media, AniListQueryType.Page    }));
            Page = new GraphQueryArgument<int>("page", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> {  AniListQueryType.Media, AniListQueryType.Page    }));
            PerPage = new GraphQueryArgument<int>("perPage", GetType(), queryType, new QueryArgumentRules(false, 25, null, new List<AniListQueryType> {  AniListQueryType.Media, AniListQueryType.Page    }));
        }
    }
}