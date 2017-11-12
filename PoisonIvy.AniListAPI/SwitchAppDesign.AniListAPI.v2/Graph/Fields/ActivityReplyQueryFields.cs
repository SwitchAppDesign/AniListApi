using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ActivityReplyQueryFields
	{
		public ActivityReplyQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the reply.
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The id of the replies creator.
		/// </summary>
		public GraphQLQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the parent activity.
		/// </summary>
		public GraphQLQueryField ActivityIdQueryField()
		{
			return ActivityId;
		}

		/// <summary>
		/// The reply text.
		/// </summary>
		public GraphQLQueryField TextQueryField()
		{
			return Text;
		}

		/// <summary>
		/// The time of the reply was created.
		/// </summary>
		public GraphQLQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The id of the replies creator.
		/// </summary>
		public GraphQLQueryField UserQueryField()
		{
			return User;
		}

		/// <summary>
		/// The users who liked the reply.
		/// </summary>
		public GraphQLQueryField LikesQueryField()
		{
			return Likes;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField UserId { get; set; }
		private GraphQLQueryField ActivityId { get; set; }
		private GraphQLQueryField Text { get; set; }
		private GraphQLQueryField CreatedAt { get; set; }
		private GraphQLQueryField User { get; set; }
		private GraphQLQueryField Likes { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			UserId = new GraphQLQueryField("userId", new FieldRules(false));
			ActivityId = new GraphQLQueryField("activityId", new FieldRules(false));
			Text = new GraphQLQueryField("text", new FieldRules(false));
			CreatedAt = new GraphQLQueryField("createdAt", new FieldRules(false));
			User = new GraphQLQueryField("user", new FieldRules(false));
			Likes = new GraphQLQueryField("likes", new FieldRules(false));
		}
	}
}
