using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available thread query arguments.
    /// </summary>
    public class ThreadQueryArguments
    {
        internal ThreadQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the thread id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the thread's creator.
        /// </summary>
        public GraphQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the last user to comment on the thread.
        /// </summary>
        public GraphQueryArgument<int> ReplyUserIdQueryArgument(int value)
        {
            return ReplyUserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by if the currently authenticated user's subscribed threads.
        /// </summary>
        public GraphQueryArgument<bool> SubscribedQueryArgument(bool value)
        {
            return Subscribed.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by thread category id
        /// </summary>
        public GraphQueryArgument<int> CategoryIdQueryArgument(int value)
        {
            return CategoryId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by thread media id category.
        /// </summary>
        public GraphQueryArgument<int> MediaCategoryIdQueryArgument(int value)
        {
            return MediaCategoryId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the thread id where the thread id is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<ThreadSort>> SortQueryArgument(IEnumerable<ThreadSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> UserId { get; set; }
        private GraphQueryArgument<int> ReplyUserId { get; set; }
        private GraphQueryArgument<bool> Subscribed { get; set; }
        private GraphQueryArgument<int> CategoryId { get; set; }
        private GraphQueryArgument<int> MediaCategoryId { get; set; }
        private GraphQueryArgument<string> Search { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQueryArgument<IEnumerable<ThreadSort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            UserId = new GraphQueryArgument<int>("userId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            ReplyUserId = new GraphQueryArgument<int>("replyUserId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            Subscribed = new GraphQueryArgument<bool>("subscribed", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            CategoryId = new GraphQueryArgument<int>("categoryId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            MediaCategoryId = new GraphQueryArgument<int>("mediaCategoryId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            Search = new GraphQueryArgument<string>("search", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            IdIn = new GraphQueryArgument<IEnumerable<int>>("id_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
            Sort = new GraphQueryArgument<IEnumerable<ThreadSort>>("sort", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Thread }));
        }
    }
}