using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserStatsQueryFields
	{
		public UserStatsQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The amount of anime the user has watched in minutes
		/// </summary>
		public GraphQLQueryField WatchedTimeQueryField()
		{
			return WatchedTime;
		}

		/// <summary>
		/// The amount of manga chapters the user has read
		/// </summary>
		public GraphQLQueryField ChaptersReadQueryField()
		{
			return ChaptersRead;
		}

		public GraphQLQueryField ActivityHistoryQueryField()
		{
			return ActivityHistory;
		}

		public GraphQLQueryField AnimeStatusDistributionQueryField()
		{
			return AnimeStatusDistribution;
		}

		public GraphQLQueryField MangaStatusDistributionQueryField()
		{
			return MangaStatusDistribution;
		}

		public GraphQLQueryField AnimeScoreDistributionQueryField()
		{
			return AnimeScoreDistribution;
		}

		public GraphQLQueryField MangaScoreDistributionQueryField()
		{
			return MangaScoreDistribution;
		}

		private GraphQLQueryField WatchedTime { get; set; }
		private GraphQLQueryField ChaptersRead { get; set; }
		private GraphQLQueryField ActivityHistory { get; set; }
		private GraphQLQueryField AnimeStatusDistribution { get; set; }
		private GraphQLQueryField MangaStatusDistribution { get; set; }
		private GraphQLQueryField AnimeScoreDistribution { get; set; }
		private GraphQLQueryField MangaScoreDistribution { get; set; }

		private void InitializeProperties()
		{
			WatchedTime = new GraphQLQueryField("watchedTime", new FieldRules(false));
			ChaptersRead = new GraphQLQueryField("chaptersRead", new FieldRules(false));
			ActivityHistory = new GraphQLQueryField("activityHistory", new FieldRules(false));
			AnimeStatusDistribution = new GraphQLQueryField("animeStatusDistribution", new FieldRules(false));
			MangaStatusDistribution = new GraphQLQueryField("mangaStatusDistribution", new FieldRules(false));
			AnimeScoreDistribution = new GraphQLQueryField("animeScoreDistribution", new FieldRules(false));
			MangaScoreDistribution = new GraphQLQueryField("mangaScoreDistribution", new FieldRules(false));
		}
	}
}
