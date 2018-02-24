using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available character connection query fields.
    /// </summary>
	public class CharacterConnectionQueryFields
	{
		internal CharacterConnectionQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of character edge query fields (found in <see cref="CharacterEdgeQueryFields"/>) to be used in the graph query (at least of character edge query field is required).</param>
        /// </summary>
        public GraphQueryField EdgesQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Edges)}) requires at least one character edge query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(CharacterEdgeQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid character edge query fields {fields.Where(x => x.ParentClassType != typeof(CharacterEdgeQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Edges.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of character query fields (found in <see cref="CharacterQueryFields"/>) to be used in the graph query (at least of character query field is required).</param>
        /// </summary>
        public GraphQueryField NodesQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Nodes)}) requires at least one character query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(CharacterQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid character query fields {fields.Where(x => x.ParentClassType != typeof(CharacterQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Nodes.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The pagination information
        /// </summary>
        public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({nameof(PageInfo)}) requires at least one page info query field.");

            if (fields.Any(x => x.ParentClassType != typeof(PageInfoQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid page info query fields {fields.Where(x => x.ParentClassType != typeof(PageInfoQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

            return PageInfo.GetGraphFieldAndSetFieldArguments(fields);
        }

		private GraphQueryField Edges { get; set; }
		private GraphQueryField Nodes { get; set; }
		private GraphQueryField PageInfo { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Edges = new GraphQueryField("edges", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			Nodes = new GraphQueryField("nodes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			PageInfo = new GraphQueryField("pageInfo", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
		}
	}
}
