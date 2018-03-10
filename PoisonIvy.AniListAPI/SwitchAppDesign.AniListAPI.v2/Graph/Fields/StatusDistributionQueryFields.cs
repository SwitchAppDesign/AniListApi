using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StatusDistributionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public StatusDistributionQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.User };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public GraphQueryField StatusQueryField()
		{
		    return new GraphQueryField("status", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of entries with this status
		/// </summary>
		public GraphQueryField AmountQueryField()
		{
		    return new GraphQueryField("amount", GetType(), _queryType, InitilizeDefaultFieldRules());
		}
	}
}
