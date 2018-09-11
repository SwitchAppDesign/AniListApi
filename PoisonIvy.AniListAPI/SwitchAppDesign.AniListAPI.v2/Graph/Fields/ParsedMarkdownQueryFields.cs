using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ParsedMarkdownQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public ParsedMarkdownQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Markdown };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        public GraphQueryField HtmlQueryField()
		{
			return new GraphQueryField("html", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
