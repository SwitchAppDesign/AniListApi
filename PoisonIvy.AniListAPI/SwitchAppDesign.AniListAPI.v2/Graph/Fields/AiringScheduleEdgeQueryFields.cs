using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available airing schedule edge query fields.
    /// </summary>
	public class AiringScheduleEdgeQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public AiringScheduleEdgeQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

        /// <summary>
        /// <param name="fields">The list of airing schedule query fields (found in <see cref="AiringScheduleQueryFields"/>) to be used in the graph query (at least of airing schedule query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("node", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(AiringScheduleQueryFields)).GetGraphFieldAndSetFieldArguments(fields);
	        
            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

	        return field;
	    }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public GraphQueryField IdQueryField()
		{
			return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());
		}

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
