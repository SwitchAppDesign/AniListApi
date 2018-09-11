using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ScoreDistributionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public ScoreDistributionQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.User };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        public GraphQueryField ScoreQueryField()
		{
		   return new GraphQueryField("score", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// The amount of list entries with this score
        /// </summary>
        public GraphQueryField AmountQueryField()
		{
			return new GraphQueryField("amount", GetType(), _queryType, InitilizeDefaultFieldRules());
		}
	}
}
