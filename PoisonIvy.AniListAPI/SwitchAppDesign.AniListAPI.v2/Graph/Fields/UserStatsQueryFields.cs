using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserStatsQueryFields
	{
		public UserStatsQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The amount of anime the user has watched in minutes
		/// </summary>
		public GraphQueryField WatchedTimeQueryField()
		{
			return WatchedTime;
		}

		/// <summary>
		/// The amount of manga chapters the user has read
		/// </summary>
		public GraphQueryField ChaptersReadQueryField()
		{
			return ChaptersRead;
		}

		public GraphQueryField ActivityHistoryQueryField()
		{
			return ActivityHistory;
		}

		public GraphQueryField AnimeStatusDistributionQueryField()
		{
			return AnimeStatusDistribution;
		}

		public GraphQueryField MangaStatusDistributionQueryField()
		{
			return MangaStatusDistribution;
		}

		public GraphQueryField AnimeScoreDistributionQueryField()
		{
			return AnimeScoreDistribution;
		}

		public GraphQueryField MangaScoreDistributionQueryField()
		{
			return MangaScoreDistribution;
		}

		private GraphQueryField WatchedTime { get; set; }
		private GraphQueryField ChaptersRead { get; set; }
		private GraphQueryField ActivityHistory { get; set; }
		private GraphQueryField AnimeStatusDistribution { get; set; }
		private GraphQueryField MangaStatusDistribution { get; set; }
		private GraphQueryField AnimeScoreDistribution { get; set; }
		private GraphQueryField MangaScoreDistribution { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			WatchedTime = new GraphQueryField("watchedTime", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			ChaptersRead = new GraphQueryField("chaptersRead", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			ActivityHistory = new GraphQueryField("activityHistory", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			AnimeStatusDistribution = new GraphQueryField("animeStatusDistribution", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			MangaStatusDistribution = new GraphQueryField("mangaStatusDistribution", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			AnimeScoreDistribution = new GraphQueryField("animeScoreDistribution", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			MangaScoreDistribution = new GraphQueryField("mangaScoreDistribution", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
