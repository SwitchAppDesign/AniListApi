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
		internal ReviewEdgeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of review query fields (found in <see cref="ReviewQueryFields"/>) to be used in the graph query (at least of review query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
	    {
	        if (fields == null || !fields.Any())
	            throw new GraphQueryFieldInvalidException($"Query field ({Node.GetType().Name}) requires at least one query field.");

	        if (fields.Any(x => x.ParentClassType != typeof(ReviewQueryFields)))
	            throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({Node.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(ReviewQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

	        return Node.GetGraphFieldAndSetFieldArguments(fields);
	    }

        private GraphQueryField Node { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
		}
	}
}
