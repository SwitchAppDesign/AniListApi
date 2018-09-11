using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available review connection query fields.
    /// </summary>
    public class ReviewConnectionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public ReviewConnectionQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Review };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// <param name="fields">The list of review edge query fields (found in <see cref="ReviewEdgeQueryFields"/>) to be used in the graph query (at least of review edge query field is required).</param>
        /// </summary>
        public GraphQueryField EdgesQueryField(IList<GraphQueryField> fields)
        {
            var field = new GraphQueryField("edges", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ReviewEdgeQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(ReviewEdgeQueryFields));

            return field;
        }

        /// <summary>
        /// <param name="fields">The list of review query fields (found in <see cref="ReviewQueryFields"/>) to be used in the graph query (at least of review query field is required).</param>
        /// </summary>
        public GraphQueryField NodesQueryField(IList<GraphQueryField> fields)
        {
            var field = new GraphQueryField("nodes", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ReviewQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(ReviewQueryFields));

            return field;
        }

        /// <summary>
        /// The pagination information
        /// <param name="fields">The list of page info query fields (found in <see cref="PageInfoQueryFields"/>) to be used in the graph query (at least of page info query field is required).</param>
        /// </summary>
        public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
        {
            var field = new GraphQueryField("pageInfo", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(PageInfoQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(PageInfoQueryFields));

            return field;
        }
	}
}
