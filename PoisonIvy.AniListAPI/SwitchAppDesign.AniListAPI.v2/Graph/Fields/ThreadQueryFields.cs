using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ThreadQueryFields
	{
		public ThreadQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the thread.
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The title of the thread.
		/// </summary>
		public GraphQLQueryField TitleQueryField()
		{
			return Title;
		}

		/// <summary>
		/// The text body of the thread (Markdown).
		/// </summary>
		public GraphQLQueryField BodyQueryField()
		{
			return Body;
		}

		/// <summary>
		/// The id of the thread owner user.
		/// </summary>
		public GraphQLQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the user who most recently commented on the thread.
		/// </summary>
		public GraphQLQueryField ReplyUserIdQueryField()
		{
			return ReplyUserId;
		}

		/// <summary>
		/// The id of the most recent comment on the thread.
		/// </summary>
		public GraphQLQueryField ReplyCommentIdQueryField()
		{
			return ReplyCommentId;
		}

		/// <summary>
		/// The number of comments on the thread.
		/// </summary>
		public GraphQLQueryField ReplyCountQueryField()
		{
			return ReplyCount;
		}

		/// <summary>
		/// The number of times users have viewed the thread.
		/// </summary>
		public GraphQLQueryField ViewCountQueryField()
		{
			return ViewCount;
		}

		/// <summary>
		/// If the thread is locked and can receive comments.
		/// </summary>
		public GraphQLQueryField IsLockedQueryField()
		{
			return IsLocked;
		}

		/// <summary>
		/// If the thread is stickied and should be displayed at the top of the page.
		/// </summary>
		public GraphQLQueryField IsStickyQueryField()
		{
			return IsSticky;
		}

		/// <summary>
		/// If the currently authenticated user is subscribed to the thread.
		/// </summary>
		public GraphQLQueryField IsSubscribedQueryField()
		{
			return IsSubscribed;
		}

		/// <summary>
		/// The time of the last reply.
		/// </summary>
		public GraphQLQueryField RepliedAtQueryField()
		{
			return RepliedAt;
		}

		/// <summary>
		/// The time of the thread creation.
		/// </summary>
		public GraphQLQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The time of the thread last update.
		/// </summary>
		public GraphQLQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// The id of the thread owner user.
		/// </summary>
		public GraphQLQueryField UserQueryField()
		{
			return User;
		}

		/// <summary>
		/// The id of the user who most recently commented on the thread.
		/// </summary>
		public GraphQLQueryField ReplyUserQueryField()
		{
			return ReplyUser;
		}

		/// <summary>
		/// The users who liked the thread.
		/// </summary>
		public GraphQLQueryField LikesQueryField()
		{
			return Likes;
		}

		/// <summary>
		/// The url for the thread page on the AniList website.
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The categories of the thread.
		/// </summary>
		public GraphQLQueryField CategoriesQueryField()
		{
			return Categories;
		}

		/// <summary>
		/// The media categories of the thread.
		/// </summary>
		public GraphQLQueryField MediaCategoriesQueryField()
		{
			return MediaCategories;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Title { get; set; }
		private GraphQLQueryField Body { get; set; }
		private GraphQLQueryField UserId { get; set; }
		private GraphQLQueryField ReplyUserId { get; set; }
		private GraphQLQueryField ReplyCommentId { get; set; }
		private GraphQLQueryField ReplyCount { get; set; }
		private GraphQLQueryField ViewCount { get; set; }
		private GraphQLQueryField IsLocked { get; set; }
		private GraphQLQueryField IsSticky { get; set; }
		private GraphQLQueryField IsSubscribed { get; set; }
		private GraphQLQueryField RepliedAt { get; set; }
		private GraphQLQueryField CreatedAt { get; set; }
		private GraphQLQueryField UpdatedAt { get; set; }
		private GraphQLQueryField User { get; set; }
		private GraphQLQueryField ReplyUser { get; set; }
		private GraphQLQueryField Likes { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField Categories { get; set; }
		private GraphQLQueryField MediaCategories { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Title = new GraphQLQueryField("title", new FieldRules(false));
			Body = new GraphQLQueryField("body", new FieldRules(false));
			UserId = new GraphQLQueryField("userId", new FieldRules(false));
			ReplyUserId = new GraphQLQueryField("replyUserId", new FieldRules(false));
			ReplyCommentId = new GraphQLQueryField("replyCommentId", new FieldRules(false));
			ReplyCount = new GraphQLQueryField("replyCount", new FieldRules(false));
			ViewCount = new GraphQLQueryField("viewCount", new FieldRules(false));
			IsLocked = new GraphQLQueryField("isLocked", new FieldRules(false));
			IsSticky = new GraphQLQueryField("isSticky", new FieldRules(false));
			IsSubscribed = new GraphQLQueryField("isSubscribed", new FieldRules(false));
			RepliedAt = new GraphQLQueryField("repliedAt", new FieldRules(false));
			CreatedAt = new GraphQLQueryField("createdAt", new FieldRules(false));
			UpdatedAt = new GraphQLQueryField("updatedAt", new FieldRules(false));
			User = new GraphQLQueryField("user", new FieldRules(false));
			ReplyUser = new GraphQLQueryField("replyUser", new FieldRules(false));
			Likes = new GraphQLQueryField("likes", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			Categories = new GraphQLQueryField("categories", new FieldRules(false));
			MediaCategories = new GraphQLQueryField("mediaCategories", new FieldRules(false));
		}
	}
}
