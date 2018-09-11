using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ThreadCommentQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public ThreadCommentQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.ThreadComment };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the comment.
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The user id of the comment's owner.
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
		    return new GraphQueryField("userId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of thread the comment belongs to.
		/// </summary>
		public GraphQueryField ThreadIdQueryField()
		{
		    return new GraphQueryField("threadId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The text content of the comment (Markdown)
		/// </summary>
		public GraphQueryField CommentQueryField()
		{
		    return new GraphQueryField("comment", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The url for the comment page on the AniList website.
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
		    return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The time of the comments creation.
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
		    return new GraphQueryField("createdAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The time of the comments last update.
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
		    return new GraphQueryField("updatedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The user id of the comment's owner.
		/// </summary>
		public GraphQueryField UserQueryField()
		{
		    return new GraphQueryField("user", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The users who liked the comment.
		/// </summary>
		public GraphQueryField LikesQueryField()
		{
		    return new GraphQueryField("likes", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The comment's child reply comments.
		/// </summary>
		public GraphQueryField ChildCommentsQueryField()
		{
		    return new GraphQueryField("childComments", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
    }
}
