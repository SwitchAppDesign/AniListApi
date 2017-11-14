using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserActivityHistoryQueryFields
	{
		public UserActivityHistoryQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The day the activity took place (Unix timestamp)
		/// </summary>
		public GraphQueryField DateQueryField()
		{
			return Date;
		}

		/// <summary>
		/// The amount of activity on the day
		/// </summary>
		public GraphQueryField AmountQueryField()
		{
			return Amount;
		}

		/// <summary>
		/// The level of activity represented on a 1-10 scale
		/// </summary>
		public GraphQueryField LevelQueryField()
		{
			return Level;
		}

		private GraphQueryField Date { get; set; }
		private GraphQueryField Amount { get; set; }
		private GraphQueryField Level { get; set; }
         
		private void InitializeProperties(AniListQueryType queryType)
		{
			Date = new GraphQueryField("date", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Amount = new GraphQueryField("amount", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Level = new GraphQueryField("level", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
