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
		internal ReviewConnectionQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of review edge query fields (found in <see cref="ReviewEdgeQueryFields"/>) to be used in the graph query (at least of review edge query field is required).</param>
        /// </summary>
        public GraphQueryField EdgesQueryField(IList<GraphQueryField> fields)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({Edges.GetType().Name}) requires at least one query field.");

            if (fields.Any(x => x.ParentClassType != typeof(ReviewEdgeQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({Edges.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(ReviewEdgeQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

            return Edges.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of review query fields (found in <see cref="ReviewQueryFields"/>) to be used in the graph query (at least of review query field is required).</param>
        /// </summary>
        public GraphQueryField NodesQueryField(IList<GraphQueryField> fields)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({Nodes.GetType().Name}) requires at least one query field.");

            if (fields.Any(x => x.ParentClassType != typeof(ReviewQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({Nodes.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(ReviewQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

            return Nodes.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The pagination information
        /// <param name="fields">The list of page info query fields (found in <see cref="PageInfoQueryFields"/>) to be used in the graph query (at least of page info query field is required).</param>
        /// </summary>
        public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({PageInfo.GetType().Name}) requires at least one query field.");

            if (fields.Any(x => x.ParentClassType != typeof(PageInfoQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({PageInfo.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(PageInfoQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

            return PageInfo.GetGraphFieldAndSetFieldArguments(fields);
        }

        private GraphQueryField Edges { get; set; }
		private GraphQueryField Nodes { get; set; }
		private GraphQueryField PageInfo { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Edges = new GraphQueryField("edges", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			Nodes = new GraphQueryField("nodes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			PageInfo = new GraphQueryField("pageInfo", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
		}
	}
}
