using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ScoreDistributionQueryFields
	{
		public ScoreDistributionQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// The amount of list entries with this score
		/// </summary>
		public GraphQLQueryField AmountQueryField()
		{
			return Amount;
		}

		private GraphQLQueryField Score { get; set; }
		private GraphQLQueryField Amount { get; set; }

		private void InitializeProperties()
		{
			Score = new GraphQLQueryField("score", new FieldRules(false));
			Amount = new GraphQLQueryField("amount", new FieldRules(false));
		}
	}
}
