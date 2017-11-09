using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    internal class ThreadCommentQueryArgument
    {
        public ThreadCommentQueryArgument()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the comment id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the thread id.
        /// </summary>
        public GraphQLQueryArgument<int> ThreadIdQueryArgument(int value)
        {
            return ThreadId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the comment's creator.
        /// </summary>
        public GraphQLQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> ThreadId { get; set; }
        private GraphQLQueryArgument<int> UserId { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            ThreadId = new GraphQLQueryArgument<int>("threadId"); 
            UserId =new GraphQLQueryArgument<int>("userId"); 
        }
    }
}