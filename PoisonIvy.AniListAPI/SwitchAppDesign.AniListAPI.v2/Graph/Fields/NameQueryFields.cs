using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available name query fields.
    /// </summary>
	public class NameQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public NameQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Staff, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        public GraphQueryField FirstQueryField()
		{
			return new GraphQueryField("first", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		public GraphQueryField LastQueryField()
		{
		    return new GraphQueryField("last", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		public GraphQueryField NativeQueryField()
		{
		    return new GraphQueryField("native", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		public GraphQueryField AlternativeQueryField()
		{
			return new GraphQueryField("alternative", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
