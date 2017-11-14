using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available thread comment query arguments.
    /// </summary>
    public class ThreadCommentQueryArgument
    {
        internal ThreadCommentQueryArgument(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the comment id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the thread id.
        /// </summary>
        public GraphQueryArgument<int> ThreadIdQueryArgument(int value)
        {
            return ThreadId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the comment's creator.
        /// </summary>
        public GraphQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> ThreadId { get; set; }
        private GraphQueryArgument<int> UserId { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
            ThreadId = new GraphQueryArgument<int>("threadId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ThreadComment })); 
            UserId =new GraphQueryArgument<int>("userId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ThreadComment })); 
        }
    }
}