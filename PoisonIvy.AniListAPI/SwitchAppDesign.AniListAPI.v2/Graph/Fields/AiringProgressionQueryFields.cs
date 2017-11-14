using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringProgressionQueryFields
	{
		public AiringProgressionQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The episode the stats were recorded at. .5 is the mid point between 2 episodes airing dates.
		/// </summary>
		public GraphQueryField EpisodeQueryField()
		{
			return Episode;
		}

		/// <summary>
		/// The average score for the media
		/// </summary>
		public GraphQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// The amount of users watching the anime
		/// </summary>
		public GraphQueryField WatchingQueryField()
		{
			return Watching;
		}

		private GraphQueryField Episode { get; set; }
		private GraphQueryField Score { get; set; }
		private GraphQueryField Watching { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Episode = new GraphQueryField("episode", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Score = new GraphQueryField("score", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Watching = new GraphQueryField("watching", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
