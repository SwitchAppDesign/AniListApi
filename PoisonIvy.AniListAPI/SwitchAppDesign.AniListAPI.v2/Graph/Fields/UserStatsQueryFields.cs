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
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public UserStatsQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.User };
	    }

        /// <summary>
        /// The amount of anime the user has watched in minutes
        /// </summary>
        public GraphQueryField WatchedTimeQueryField()
		{
			return new GraphQueryField("watchedTime", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of manga chapters the user has read
		/// </summary>
		public GraphQueryField ChaptersReadQueryField()
		{
		    return new GraphQueryField("chaptersRead", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// <param name="fields">The list of user activity history fields (found in <see cref="UserActivityHistoryQueryFields"/>) to be used in the graph query (at least of user activity history query field is required).</param>
        /// </summary>
        public GraphQueryField ActivityHistoryQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("activityHistory", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(UserActivityHistoryQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// <param name="fields">The list of status distribution fields (found in <see cref="StatusDistributionQueryFields"/>) to be used in the graph query (at least of status distribution query field is required).</param>
        /// </summary>
        public GraphQueryField AnimeStatusDistributionQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("animeStatusDistribution", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StatusDistributionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
		}

        /// <summary>
        /// <param name="fields">The list of status distribution fields (found in <see cref="StatusDistributionQueryFields"/>) to be used in the graph query (at least of status distribution query field is required).</param>
        /// </summary>
        public GraphQueryField MangaStatusDistributionQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("mangaStatusDistribution", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StatusDistributionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// <param name="fields">The list of score distribution fields (found in <see cref="ScoreDistributionQueryFields"/>) to be used in the graph query (at least of score distribution query field is required).</param>
        /// </summary>
        public GraphQueryField AnimeScoreDistributionQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("animeScoreDistribution", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ScoreDistributionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

	    /// <summary>
	    /// <param name="fields">The list of score distribution fields (found in <see cref="ScoreDistributionQueryFields"/>) to be used in the graph query (at least of score distribution query field is required).</param>
	    /// </summary>
        public GraphQueryField MangaScoreDistributionQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("mangaScoreDistribution", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ScoreDistributionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
		}

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
