using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media status query fields.
    /// </summary>
	public class MediaStatsQueryFields
	{
	    internal MediaStatsQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField ScoreDistributionQueryField()
		{
			return ScoreDistribution;
		}

		public GraphQueryField StatusDistributionQueryField()
		{
			return StatusDistribution;
		}

		public GraphQueryField AiringProgressionQueryField()
		{
			return AiringProgression;
		}

		private GraphQueryField ScoreDistribution { get; set; }
		private GraphQueryField StatusDistribution { get; set; }
		private GraphQueryField AiringProgression { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			ScoreDistribution = new GraphQueryField("scoreDistribution", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			StatusDistribution = new GraphQueryField("statusDistribution", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			AiringProgression = new GraphQueryField("airingProgression", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
