using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class ThreadQueryArguments
    {
        public ThreadQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the thread id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the thread's creator.
        /// </summary>
        public GraphQLQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the last user to comment on the thread.
        /// </summary>
        public GraphQLQueryArgument<int> ReplyUserIdQueryArgument(int value)
        {
            return ReplyUserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by if the currently authenticated user's subscribed threads.
        /// </summary>
        public GraphQLQueryArgument<bool> SubscribedQueryArgument(bool value)
        {
            return Subscribed.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by thread category id
        /// </summary>
        public GraphQLQueryArgument<int> CategoryIdQueryArgument(int value)
        {
            return CategoryId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by thread media id category.
        /// </summary>
        public GraphQLQueryArgument<int> MediaCategoryIdQueryArgument(int value)
        {
            return MediaCategoryId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQLQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the thread id where the thread id is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<ThreadSort>> SortQueryArgument(IEnumerable<ThreadSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> UserId { get; set; }
        private GraphQLQueryArgument<int> ReplyUserId { get; set; }
        private GraphQLQueryArgument<bool> Subscribed { get; set; }
        private GraphQLQueryArgument<int> CategoryId { get; set; }
        private GraphQLQueryArgument<int> MediaCategoryId { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<ThreadSort>> Sort { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            UserId = new GraphQLQueryArgument<int>("userId");
            ReplyUserId = new GraphQLQueryArgument<int>("replyUserId");
            Subscribed = new GraphQLQueryArgument<bool>("subscribed");
            CategoryId = new GraphQLQueryArgument<int>("categoryId");
            MediaCategoryId = new GraphQLQueryArgument<int>("mediaCategoryId");
            Search = new GraphQLQueryArgument<string>("search");
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in");
            Sort = new GraphQLQueryArgument<IEnumerable<ThreadSort>>("sort");
        }
    }
}