using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class ReviewQueryArguments
    {
        public ReviewQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by a review's id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by a media's id.
        /// </summary>
        public GraphQLQueryArgument<int> MediaIdQueryArgument(int value)
        {
            return MediaId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by user's id.
        /// </summary>
        public GraphQLQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by media type.
        /// </summary>
        public GraphQLQueryArgument<MediaType> MediaTypeQueryArgument(MediaType value)
        {
            return MediaType.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQLQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<ReviewSort>> SortQueryArgument(IEnumerable<ReviewSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The review limit.
        /// </summary>
        public GraphQLQueryArgument<int> LimitQueryArgument(int value)
        {
            return Limit.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The page number.
        /// </summary>
        public GraphQLQueryArgument<int> PageQueryArgument(int value)
        {
            return Page.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The amount of entries per page (Max 25).
        /// </summary>
        public GraphQLQueryArgument<int> SortQueryArgument(int value)
        {
            return PerPage.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> MediaId { get; set; }
        private GraphQLQueryArgument<int> UserId { get; set; }
        private GraphQLQueryArgument<MediaType> MediaType { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<IEnumerable<ReviewSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQLQueryArgument<int> Limit { get; set; }
        private GraphQLQueryArgument<int> Page { get; set; }
        private GraphQLQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            MediaId = new GraphQLQueryArgument<int>("mediaId", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            UserId = new GraphQLQueryArgument<int>("userId", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            MediaType = new GraphQLQueryArgument<MediaType>("mediaType", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            Search = new GraphQLQueryArgument<string>("search", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));
            Sort = new GraphQLQueryArgument<IEnumerable<ReviewSort>>("sort", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Review }));

            Limit = new GraphQLQueryArgument<int>("limit", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Page = new GraphQLQueryArgument<int>("page", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PerPage = new GraphQLQueryArgument<int>("perPage", new QueryArgumentRules(false, 25, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}