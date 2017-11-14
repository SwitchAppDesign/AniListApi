using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ThreadCommentQueryFields
	{
		public ThreadCommentQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the comment.
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The user id of the comment's owner.
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of thread the comment belongs to.
		/// </summary>
		public GraphQueryField ThreadIdQueryField()
		{
			return ThreadId;
		}

		/// <summary>
		/// The text content of the comment (Markdown)
		/// </summary>
		public GraphQueryField CommentQueryField()
		{
			return Comment;
		}

		/// <summary>
		/// The url for the comment page on the AniList website.
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The time of the comments creation.
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The time of the comments last update.
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// The user id of the comment's owner.
		/// </summary>
		public GraphQueryField UserQueryField()
		{
			return User;
		}

		/// <summary>
		/// The users who liked the comment.
		/// </summary>
		public GraphQueryField LikesQueryField()
		{
			return Likes;
		}

		/// <summary>
		/// The comment's child reply comments.
		/// </summary>
		public GraphQueryField ChildCommentsQueryField()
		{
			return ChildComments;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField UserId { get; set; }
		private GraphQueryField ThreadId { get; set; }
		private GraphQueryField Comment { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField CreatedAt { get; set; }
		private GraphQueryField UpdatedAt { get; set; }
		private GraphQueryField User { get; set; }
		private GraphQueryField Likes { get; set; }
		private GraphQueryField ChildComments { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			UserId = new GraphQueryField("userId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			ThreadId = new GraphQueryField("threadId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			Comment = new GraphQueryField("comment", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			CreatedAt = new GraphQueryField("createdAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			UpdatedAt = new GraphQueryField("updatedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			User = new GraphQueryField("user", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			Likes = new GraphQueryField("likes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
			ChildComments = new GraphQueryField("childComments", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ThreadComment }));
		}
	}
}
