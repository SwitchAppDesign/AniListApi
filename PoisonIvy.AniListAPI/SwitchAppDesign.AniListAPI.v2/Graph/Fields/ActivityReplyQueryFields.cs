using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ActivityReplyQueryFields
	{
		public ActivityReplyQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the reply.
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The id of the replies creator.
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the parent activity.
		/// </summary>
		public GraphQueryField ActivityIdQueryField()
		{
			return ActivityId;
		}

		/// <summary>
		/// The reply text.
		/// </summary>
		public GraphQueryField TextQueryField()
		{
			return Text;
		}

		/// <summary>
		/// The time of the reply was created.
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The id of the replies creator.
		/// </summary>
		public GraphQueryField UserQueryField()
		{
			return User;
		}

		/// <summary>
		/// The users who liked the reply.
		/// </summary>
		public GraphQueryField LikesQueryField()
		{
			return Likes;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField UserId { get; set; }
		private GraphQueryField ActivityId { get; set; }
		private GraphQueryField Text { get; set; }
		private GraphQueryField CreatedAt { get; set; }
		private GraphQueryField User { get; set; }
		private GraphQueryField Likes { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
			UserId = new GraphQueryField("userId", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
			ActivityId = new GraphQueryField("activityId", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
			Text = new GraphQueryField("text", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
			CreatedAt = new GraphQueryField("createdAt", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
			User = new GraphQueryField("user", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
			Likes = new GraphQueryField("likes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
		}
	}
}
