using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available page query fields.
    /// </summary>
	public class PageQueryFields
	{
	    internal PageQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The pagination information
		/// </summary>
		public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({PageInfo.GetType().Name}) requires at least one query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaTitleQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({PageInfo.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(MediaTitleQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return PageInfo.GetGraphFieldAndSetFieldArguments(fields);
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
			PageInfo = new GraphQueryField("pageInfo", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Users = new GraphQueryField("users", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Media = new GraphQueryField("media", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Characters = new GraphQueryField("characters", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Staff = new GraphQueryField("staff", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Studios = new GraphQueryField("studios", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			MediaList = new GraphQueryField("mediaList", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			AiringSchedules = new GraphQueryField("airingSchedules", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Followers = new GraphQueryField("followers", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Followings = new GraphQueryField("followings", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			ActivityReplies = new GraphQueryField("activityReplies", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Threads = new GraphQueryField("threads", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			ThreadComments = new GraphQueryField("threadComments", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			Reviews = new GraphQueryField("reviews", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
		}
	}
}
