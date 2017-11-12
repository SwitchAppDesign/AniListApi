using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class PageQueryFields
	{
		public PageQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The pagination information
		/// </summary>
		public GraphQLQueryField PageInfoQueryField()
		{
			return PageInfo;
		}

		public GraphQLQueryField UsersQueryField()
		{
			return Users;
		}

		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		public GraphQLQueryField CharactersQueryField()
		{
			return Characters;
		}

		public GraphQLQueryField StaffQueryField()
		{
			return Staff;
		}

		public GraphQLQueryField StudiosQueryField()
		{
			return Studios;
		}

		public GraphQLQueryField MediaListQueryField()
		{
			return MediaList;
		}

		public GraphQLQueryField AiringSchedulesQueryField()
		{
			return AiringSchedules;
		}

		public GraphQLQueryField FollowersQueryField()
		{
			return Followers;
		}

		public GraphQLQueryField FollowingsQueryField()
		{
			return Followings;
		}

		public GraphQLQueryField ActivityRepliesQueryField()
		{
			return ActivityReplies;
		}

		public GraphQLQueryField ThreadsQueryField()
		{
			return Threads;
		}

		public GraphQLQueryField ThreadCommentsQueryField()
		{
			return ThreadComments;
		}

		public GraphQLQueryField ReviewsQueryField()
		{
			return Reviews;
		}

		private GraphQLQueryField PageInfo { get; set; }
		private GraphQLQueryField Users { get; set; }
		private GraphQLQueryField Media { get; set; }
		private GraphQLQueryField Characters { get; set; }
		private GraphQLQueryField Staff { get; set; }
		private GraphQLQueryField Studios { get; set; }
		private GraphQLQueryField MediaList { get; set; }
		private GraphQLQueryField AiringSchedules { get; set; }
		private GraphQLQueryField Followers { get; set; }
		private GraphQLQueryField Followings { get; set; }
		private GraphQLQueryField ActivityReplies { get; set; }
		private GraphQLQueryField Threads { get; set; }
		private GraphQLQueryField ThreadComments { get; set; }
		private GraphQLQueryField Reviews { get; set; }

		private void InitializeProperties()
		{
			PageInfo = new GraphQLQueryField("pageInfo", new FieldRules(false));
			Users = new GraphQLQueryField("users", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
			Characters = new GraphQLQueryField("characters", new FieldRules(false));
			Staff = new GraphQLQueryField("staff", new FieldRules(false));
			Studios = new GraphQLQueryField("studios", new FieldRules(false));
			MediaList = new GraphQLQueryField("mediaList", new FieldRules(false));
			AiringSchedules = new GraphQLQueryField("airingSchedules", new FieldRules(false));
			Followers = new GraphQLQueryField("followers", new FieldRules(false));
			Followings = new GraphQLQueryField("followings", new FieldRules(false));
			ActivityReplies = new GraphQLQueryField("activityReplies", new FieldRules(false));
			Threads = new GraphQLQueryField("threads", new FieldRules(false));
			ThreadComments = new GraphQLQueryField("threadComments", new FieldRules(false));
			Reviews = new GraphQLQueryField("reviews", new FieldRules(false));
		}
	}
}
