using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringProgressionQueryFields
	{
		public AiringProgressionQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The episode the stats were recorded at. .5 is the mid point between 2 episodes airing dates.
		/// </summary>
		public GraphQLQueryField EpisodeQueryField()
		{
			return Episode;
		}

		/// <summary>
		/// The average score for the media
		/// </summary>
		public GraphQLQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// The amount of users watching the anime
		/// </summary>
		public GraphQLQueryField WatchingQueryField()
		{
			return Watching;
		}

		private GraphQLQueryField Episode { get; set; }
		private GraphQLQueryField Score { get; set; }
		private GraphQLQueryField Watching { get; set; }

		private void InitializeProperties()
		{
			Episode = new GraphQLQueryField("episode", new FieldRules(false));
			Score = new GraphQLQueryField("score", new FieldRules(false));
			Watching = new GraphQLQueryField("watching", new FieldRules(false));
		}
	}
}
