using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
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

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> MediaId { get; set; }
        private GraphQLQueryArgument<int> UserId { get; set; }
        private GraphQLQueryArgument<MediaType> MediaType { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<IEnumerable<ReviewSort>> Sort { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            MediaId = new GraphQLQueryArgument<int>("mediaId");
            UserId = new GraphQLQueryArgument<int>("userId");
            MediaType = new GraphQLQueryArgument<MediaType>("mediaType");
            Search = new GraphQLQueryArgument<string>("search");
            Sort = new GraphQLQueryArgument<IEnumerable<ReviewSort>>("sort");
        }
    }
}