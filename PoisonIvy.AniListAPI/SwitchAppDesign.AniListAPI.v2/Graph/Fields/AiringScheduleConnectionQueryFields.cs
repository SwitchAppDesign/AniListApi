using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available Airing schedule connection query fields.
    /// </summary>
	public class AiringScheduleConnectionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public AiringScheduleConnectionQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.AiringSchedule };
	    }

        /// <summary>
        /// <param name="fields">The list of airing schedule edge query fields (found in <see cref="AiringScheduleEdgeQueryFields"/>) to be used in the graph query (at least of airing schedule edge query field is required).</param>
        /// </summary>
        public GraphQueryField EdgesQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("pageInfo", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(AiringScheduleEdgeQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

	        return field;
	    }

        /// <summary>
        /// <param name="fields">The list of airing schedule query fields (found in <see cref="AiringScheduleQueryFields"/>) to be used in the graph query (at least of airing schedule query field is required).</param>
        /// </summary>
        public GraphQueryField NodesQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("nodes", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(AiringScheduleQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

	        FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
	    }

	    /// <summary>
	    /// The pagination information
	    /// </summary>
	    public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("edges", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(PageInfoQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

	        FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }

}
