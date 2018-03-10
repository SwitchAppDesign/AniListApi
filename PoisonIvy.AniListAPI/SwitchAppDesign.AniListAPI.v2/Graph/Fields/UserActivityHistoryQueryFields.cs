using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserActivityHistoryQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public UserActivityHistoryQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.User };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public GraphQueryField DateQueryField()
		{
		    return new GraphQueryField("date", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of activity on the day
		/// </summary>
		public GraphQueryField AmountQueryField()
		{
		    return new GraphQueryField("amount", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The level of activity represented on a 1-10 scale
		/// </summary>
		public GraphQueryField LevelQueryField()
		{
			return new GraphQueryField("level", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		private GraphQueryField Date { get; set; }
		private GraphQueryField Amount { get; set; }
		private GraphQueryField Level { get; set; }
	}
}
