using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available review edge query fields.
    /// </summary>
	public class ReviewEdgeQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public ReviewEdgeQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Review };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// <param name="fields">The list of review query fields (found in <see cref="ReviewQueryFields"/>) to be used in the graph query (at least of review query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("node", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ReviewQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(ReviewQueryFields));

	        return field;
	    }
	}
}
