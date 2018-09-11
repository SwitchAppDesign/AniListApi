using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserOptionsQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public UserOptionsQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.User };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        public GraphQueryField TitleLanguageQueryField()
		{
		    return new GraphQueryField("titleLanguage", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		public GraphQueryField DisplayAdultContentQueryField()
		{
			return new GraphQueryField("displayAdultContent", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
