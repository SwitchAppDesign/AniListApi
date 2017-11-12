using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaStatsQueryFields
	{
		public MediaStatsQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField ScoreDistributionQueryField()
		{
			return ScoreDistribution;
		}

		public GraphQLQueryField StatusDistributionQueryField()
		{
			return StatusDistribution;
		}

		public GraphQLQueryField AiringProgressionQueryField()
		{
			return AiringProgression;
		}

		private GraphQLQueryField ScoreDistribution { get; set; }
		private GraphQLQueryField StatusDistribution { get; set; }
		private GraphQLQueryField AiringProgression { get; set; }

		private void InitializeProperties()
		{
			ScoreDistribution = new GraphQLQueryField("scoreDistribution", new FieldRules(false));
			StatusDistribution = new GraphQLQueryField("statusDistribution", new FieldRules(false));
			AiringProgression = new GraphQLQueryField("airingProgression", new FieldRules(false));
		}
	}
}
