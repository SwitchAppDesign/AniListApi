using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available staff connection query fields.
    /// </summary>
	public class StaffConnectionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public StaffConnectionQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Staff, AniListQueryType.Media };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// <param name="fields">The list of staff edge fields (found in <see cref="StaffEdgeQueryFields"/>) to be used in the graph query (at least of staff edge query field is required).</param>
        /// </summary>
        public GraphQueryField EdgesQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("edges", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StaffEdgeQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);    

		    return field;
        }

        /// <summary>
        /// <param name="fields">The list of staff fields (found in <see cref="StaffQueryFields"/>) to be used in the graph query (at least of staff query field is required).</param>
        /// </summary>
        public GraphQueryField NodesQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("nodes", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StaffQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

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
	}
}
