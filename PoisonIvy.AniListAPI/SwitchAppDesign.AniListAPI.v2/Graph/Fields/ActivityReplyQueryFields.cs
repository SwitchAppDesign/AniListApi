using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ActivityReplyQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        public ActivityReplyQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;

            _allowedQueryTypes = new List<AniListQueryType>
            {
                AniListQueryType.ActivityReply
            };
        }

		/// <summary>
		/// The id of the reply.
		/// </summary>
		public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the replies creator.
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
		    return new GraphQueryField("userId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the parent activity.
		/// </summary>
		public GraphQueryField ActivityIdQueryField()
		{
		    return new GraphQueryField("activityId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The reply text.
		/// </summary>
		public GraphQueryField TextQueryField()
		{
		    return new GraphQueryField("text", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The time of the reply was created.
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
		    return new GraphQueryField("createdAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the replies creator.
		/// </summary>
		public GraphQueryField UserQueryField()
		{
		    return new GraphQueryField("user", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The users who liked the reply.
		/// </summary>
		public GraphQueryField LikesQueryField()
		{
			return new GraphQueryField("likes", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
