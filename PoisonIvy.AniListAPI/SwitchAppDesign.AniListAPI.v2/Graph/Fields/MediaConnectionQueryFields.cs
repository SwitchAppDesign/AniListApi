using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media connection query fields.
    /// </summary>
	public class MediaConnectionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        internal MediaConnectionQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.Media, AniListQueryType.Page};
        }

        /// <summary>
        /// <param name="fields">The list of media edge query fields (found in <see cref="MediaEdgeQueryFields"/>) to be used in the graph query (at least of media edge query field is required).</param>
        /// </summary>
        public GraphQueryField EdgesQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("edges", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaEdgeQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

        /// <summary>
        /// <param name="fields">The list of media query fields (found in <see cref="MediaQueryFields"/>) to be used in the graph query (at least of media query field is required).</param>
        /// </summary>
        public GraphQueryField NodesQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("nodes", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

	    /// <summary>
	    /// The pagination information
	    /// </summary>
	    public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("pageInfo", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(PageInfoQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

	        FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
