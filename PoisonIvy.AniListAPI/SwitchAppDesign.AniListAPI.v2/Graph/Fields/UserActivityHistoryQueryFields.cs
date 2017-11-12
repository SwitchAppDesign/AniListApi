using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserActivityHistoryQueryFields
	{
		public UserActivityHistoryQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The day the activity took place (Unix timestamp)
		/// </summary>
		public GraphQLQueryField DateQueryField()
		{
			return Date;
		}

		/// <summary>
		/// The amount of activity on the day
		/// </summary>
		public GraphQLQueryField AmountQueryField()
		{
			return Amount;
		}

		/// <summary>
		/// The level of activity represented on a 1-10 scale
		/// </summary>
		public GraphQLQueryField LevelQueryField()
		{
			return Level;
		}

		private GraphQLQueryField Date { get; set; }
		private GraphQLQueryField Amount { get; set; }
		private GraphQLQueryField Level { get; set; }

		private void InitializeProperties()
		{
			Date = new GraphQLQueryField("date", new FieldRules(false));
			Amount = new GraphQLQueryField("amount", new FieldRules(false));
			Level = new GraphQLQueryField("level", new FieldRules(false));
		}
	}
}
