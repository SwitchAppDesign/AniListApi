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
		internal AiringScheduleEdgeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of airing schedule query fields (found in <see cref="AiringScheduleQueryFields"/>) to be used in the graph query (at least of airing schedule query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
	    {
	        if (fields == null || !fields.Any())
	            throw new GraphQueryFieldInvalidException($"Query field ({Node.GetType().Name}) requires at least one query field.");

	        if (fields.Any(x => x.ParentClassType != typeof(AiringScheduleQueryFields)))
	            throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({Node.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(AiringScheduleQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

	        return Node.GetGraphFieldAndSetFieldArguments(fields);
	    }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public GraphQueryField IdQueryField()
		{
			return Id;
		}

		private GraphQueryField Node { get; set; }
		private GraphQueryField Id { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
