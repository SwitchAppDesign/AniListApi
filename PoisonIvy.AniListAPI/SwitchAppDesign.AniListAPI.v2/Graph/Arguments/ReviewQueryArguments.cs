using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available review query arguments.
    /// </summary>
    public class ReviewQueryArguments
    {
        internal ReviewQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by a review's id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by a media's id.
        /// </summary>
        public GraphQueryArgument<int> MediaIdQueryArgument(int value)
        {
            return MediaId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by user's id.
        /// </summary>
        public GraphQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by media type.
        /// </summary>
        public GraphQueryArgument<MediaType> MediaTypeQueryArgument(MediaType value)
        {
            return MediaType.GetQueryArgumentAndSetValue(value);
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
        public GraphQueryArgument<IEnumerable<ReviewSort>> SortQueryArgument(IEnumerable<ReviewSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The review limit.
        /// </summary>
        public GraphQueryArgument<int> LimitQueryArgument(int value)
        {
            return Limit.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The page number.
        /// </summary>
        public GraphQueryArgument<int> PageQueryArgument(int value)
        {
            return Page.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The amount of entries per page (Max 25).
        /// </summary>
        public GraphQueryArgument<int> SortQueryArgument(int value)
        {
            return PerPage.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> MediaId { get; set; }
        private GraphQueryArgument<int> UserId { get; set; }
        private GraphQueryArgument<MediaType> MediaType { get; set; }
        private GraphQueryArgument<string> Search { get; set; }
        private GraphQueryArgument<IEnumerable<ReviewSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQueryArgument<int> Limit { get; set; }
        private GraphQueryArgument<int> Page { get; set; }
        private GraphQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            MediaId = new GraphQueryArgument<int>("mediaId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            UserId = new GraphQueryArgument<int>("userId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            MediaType = new GraphQueryArgument<MediaType>("mediaType", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            Search = new GraphQueryArgument<string>("search", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            Sort = new GraphQueryArgument<IEnumerable<ReviewSort>>("sort", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));

            Limit = new GraphQueryArgument<int>("limit", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Page = new GraphQueryArgument<int>("page", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PerPage = new GraphQueryArgument<int>("perPage", queryType, new QueryArgumentRules(false, 25, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}