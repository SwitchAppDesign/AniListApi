using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
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

		public GraphQueryField NodeQueryField()
		{
			return Node;
		}

		private GraphQueryField Node { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
		}
	}
}
