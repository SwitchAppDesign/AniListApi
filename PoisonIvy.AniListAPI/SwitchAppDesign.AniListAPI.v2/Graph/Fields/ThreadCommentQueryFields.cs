using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ThreadCommentQueryFields
	{
		public ThreadCommentQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the comment.
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The user id of the comment's owner.
		/// </summary>
		public GraphQLQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of thread the comment belongs to.
		/// </summary>
		public GraphQLQueryField ThreadIdQueryField()
		{
			return ThreadId;
		}

		/// <summary>
		/// The text content of the comment (Markdown)
		/// </summary>
		public GraphQLQueryField CommentQueryField()
		{
			return Comment;
		}

		/// <summary>
		/// The url for the comment page on the AniList website.
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The time of the comments creation.
		/// </summary>
		public GraphQLQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The time of the comments last update.
		/// </summary>
		public GraphQLQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// The user id of the comment's owner.
		/// </summary>
		public GraphQLQueryField UserQueryField()
		{
			return User;
		}

		/// <summary>
		/// The users who liked the comment.
		/// </summary>
		public GraphQLQueryField LikesQueryField()
		{
			return Likes;
		}

		/// <summary>
		/// The comment's child reply comments.
		/// </summary>
		public GraphQLQueryField ChildCommentsQueryField()
		{
			return ChildComments;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField UserId { get; set; }
		private GraphQLQueryField ThreadId { get; set; }
		private GraphQLQueryField Comment { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField CreatedAt { get; set; }
		private GraphQLQueryField UpdatedAt { get; set; }
		private GraphQLQueryField User { get; set; }
		private GraphQLQueryField Likes { get; set; }
		private GraphQLQueryField ChildComments { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			UserId = new GraphQLQueryField("userId", new FieldRules(false));
			ThreadId = new GraphQLQueryField("threadId", new FieldRules(false));
			Comment = new GraphQLQueryField("comment", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			CreatedAt = new GraphQLQueryField("createdAt", new FieldRules(false));
			UpdatedAt = new GraphQLQueryField("updatedAt", new FieldRules(false));
			User = new GraphQLQueryField("user", new FieldRules(false));
			Likes = new GraphQLQueryField("likes", new FieldRules(false));
			ChildComments = new GraphQLQueryField("childComments", new FieldRules(false));
		}
	}
}
