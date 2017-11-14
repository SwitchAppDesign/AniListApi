using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class PageQueryFields
	{
		public PageQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The pagination information
		/// </summary>
		public GraphQueryField PageInfoQueryField()
		{
			return PageInfo;
		}

		public GraphQueryField UsersQueryField()
		{
			return Users;
		}

		public GraphQueryField MediaQueryField()
		{
			return Media;
		}

		public GraphQueryField CharactersQueryField()
		{
			return Characters;
		}

		public GraphQueryField StaffQueryField()
		{
			return Staff;
		}

		public GraphQueryField StudiosQueryField()
		{
			return Studios;
		}

		public GraphQueryField MediaListQueryField()
		{
			return MediaList;
		}

		public GraphQueryField AiringSchedulesQueryField()
		{
			return AiringSchedules;
		}

		public GraphQueryField FollowersQueryField()
		{
			return Followers;
		}

		public GraphQueryField FollowingsQueryField()
		{
			return Followings;
		}

		public GraphQueryField ActivityRepliesQueryField()
		{
			return ActivityReplies;
		}

		public GraphQueryField ThreadsQueryField()
		{
			return Threads;
		}

		public GraphQueryField ThreadCommentsQueryField()
		{
			return ThreadComments;
		}

		public GraphQueryField ReviewsQueryField()
		{
			return Reviews;
		}

		private GraphQueryField PageInfo { get; set; }
		private GraphQueryField Users { get; set; }
		private GraphQueryField Media { get; set; }
		private GraphQueryField Characters { get; set; }
		private GraphQueryField Staff { get; set; }
		private GraphQueryField Studios { get; set; }
		private GraphQueryField MediaList { get; set; }
		private GraphQueryField AiringSchedules { get; set; }
		private GraphQueryField Followers { get; set; }
		private GraphQueryField Followings { get; set; }
		private GraphQueryField ActivityReplies { get; set; }
		private GraphQueryField Threads { get; set; }
		private GraphQueryField ThreadComments { get; set; }
		private GraphQueryField Reviews { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			PageInfo = new GraphQueryField("pageInfo", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Users = new GraphQueryField("users", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Media = new GraphQueryField("media", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Characters = new GraphQueryField("characters", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Staff = new GraphQueryField("staff", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Studios = new GraphQueryField("studios", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			MediaList = new GraphQueryField("mediaList", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			AiringSchedules = new GraphQueryField("airingSchedules", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Followers = new GraphQueryField("followers", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Followings = new GraphQueryField("followings", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			ActivityReplies = new GraphQueryField("activityReplies", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Threads = new GraphQueryField("threads", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			ThreadComments = new GraphQueryField("threadComments", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Reviews = new GraphQueryField("reviews", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
		}
	}
}
