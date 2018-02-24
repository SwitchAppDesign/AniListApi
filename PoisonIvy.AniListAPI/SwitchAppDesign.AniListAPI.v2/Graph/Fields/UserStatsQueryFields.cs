using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
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

        /// <summary>
        /// <param name="fields">The list of user activity history fields (found in <see cref="UserActivityHistoryQueryFields"/>) to be used in the graph query (at least of user activity history query field is required).</param>
        /// </summary>
        public GraphQueryField ActivityHistoryQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(ActivityHistory)}) requires at least one user activity history query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(UserActivityHistoryQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid user activity history query fields {fields.Where(x => x.ParentClassType != typeof(UserActivityHistoryQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return ActivityHistory.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of status distribution fields (found in <see cref="StatusDistributionQueryFields"/>) to be used in the graph query (at least of status distribution query field is required).</param>
        /// </summary>
        public GraphQueryField AnimeStatusDistributionQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(AnimeStatusDistribution)}) requires at least one status distribution stats query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StatusDistributionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid status distribution query fields {fields.Where(x => x.ParentClassType != typeof(StatusDistributionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return AnimeStatusDistribution.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of status distribution fields (found in <see cref="StatusDistributionQueryFields"/>) to be used in the graph query (at least of status distribution query field is required).</param>
        /// </summary>
        public GraphQueryField MangaStatusDistributionQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(MangaStatusDistribution)}) requires at least one status distribution stats query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StatusDistributionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid status distribution query fields {fields.Where(x => x.ParentClassType != typeof(StatusDistributionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return MangaStatusDistribution.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of score distribution fields (found in <see cref="ScoreDistributionQueryFields"/>) to be used in the graph query (at least of score distribution query field is required).</param>
        /// </summary>
        public GraphQueryField AnimeScoreDistributionQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(AnimeScoreDistribution)}) requires at least one score distribution query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(ScoreDistributionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid score distribution query fields {fields.Where(x => x.ParentClassType != typeof(ScoreDistributionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return AnimeScoreDistribution.GetGraphFieldAndSetFieldArguments(fields);
        }

	    /// <summary>
	    /// <param name="fields">The list of score distribution fields (found in <see cref="ScoreDistributionQueryFields"/>) to be used in the graph query (at least of score distribution query field is required).</param>
	    /// </summary>
        public GraphQueryField MangaScoreDistributionQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(MangaScoreDistribution)}) requires at least one score distribution query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(ScoreDistributionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid score distribution query fields {fields.Where(x => x.ParentClassType != typeof(ScoreDistributionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return MangaScoreDistribution.GetGraphFieldAndSetFieldArguments(fields);
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
			WatchedTime = new GraphQueryField("watchedTime", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			ChaptersRead = new GraphQueryField("chaptersRead", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			ActivityHistory = new GraphQueryField("activityHistory", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			AnimeStatusDistribution = new GraphQueryField("animeStatusDistribution", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			MangaStatusDistribution = new GraphQueryField("mangaStatusDistribution", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			AnimeScoreDistribution = new GraphQueryField("animeScoreDistribution", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			MangaScoreDistribution = new GraphQueryField("mangaScoreDistribution", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
