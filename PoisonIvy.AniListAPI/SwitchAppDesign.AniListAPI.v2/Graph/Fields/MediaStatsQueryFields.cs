using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media status query fields.
    /// </summary>
	public class MediaStatsQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public MediaStatsQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        public GraphQueryField ScoreDistributionQueryField()
		{
		    return new GraphQueryField("scoreDistribution", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		public GraphQueryField StatusDistributionQueryField()
		{
		    return new GraphQueryField("statusDistribution", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		public GraphQueryField AiringProgressionQueryField()
		{
			return new GraphQueryField("airingProgression", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
