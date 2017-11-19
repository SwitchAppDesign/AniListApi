using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ScoreDistributionQueryFields
	{
		public ScoreDistributionQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// The amount of list entries with this score
		/// </summary>
		public GraphQueryField AmountQueryField()
		{
			return Amount;
		}

		private GraphQueryField Score { get; set; }
		private GraphQueryField Amount { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Score = new GraphQueryField("score", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.User }));
			Amount = new GraphQueryField("amount", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.User }));
		}
	}
}
