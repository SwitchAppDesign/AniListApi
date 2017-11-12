using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StatusDistributionQueryFields
	{
		public StatusDistributionQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The day the activity took place (Unix timestamp)
		/// </summary>
		public GraphQLQueryField StatusQueryField()
		{
			return Status;
		}

		/// <summary>
		/// The amount of entries with this status
		/// </summary>
		public GraphQLQueryField AmountQueryField()
		{
			return Amount;
		}

		private GraphQLQueryField Status { get; set; }
		private GraphQLQueryField Amount { get; set; }

		private void InitializeProperties()
		{
			Status = new GraphQLQueryField("status", new FieldRules(false));
			Amount = new GraphQLQueryField("amount", new FieldRules(false));
		}
	}
}
