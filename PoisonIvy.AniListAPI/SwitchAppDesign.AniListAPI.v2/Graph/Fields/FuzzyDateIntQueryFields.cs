using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FuzzyDateIntQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        public FuzzyDateIntQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.Media, AniListQueryType.Page};
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        public GraphQueryField FuzzyDateQueryField()
		{
			return new GraphQueryField("FuzzyDate", GetType(), _queryType, InitilizeDefaultFieldRules());
		}
    }
}
