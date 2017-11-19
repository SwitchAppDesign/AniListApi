using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StatusDistributionQueryFields
	{
		public StatusDistributionQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The day the activity took place (Unix timestamp)
		/// </summary>
		public GraphQueryField StatusQueryField()
		{
			return Status;
		}

		/// <summary>
		/// The amount of entries with this status
		/// </summary>
		public GraphQueryField AmountQueryField()
		{
			return Amount;
		}

		private GraphQueryField Status { get; set; }
		private GraphQueryField Amount { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Status = new GraphQueryField("status", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.User }));
			Amount = new GraphQueryField("amount", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.User }));
		}
	}
}
