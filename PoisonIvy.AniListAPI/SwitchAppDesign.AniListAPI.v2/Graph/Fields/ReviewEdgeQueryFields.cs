using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ReviewEdgeQueryFields
	{
		public ReviewEdgeQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField NodeQueryField()
		{
			return Node;
		}

		private GraphQLQueryField Node { get; set; }

		private void InitializeProperties()
		{
			Node = new GraphQLQueryField("node", new FieldRules(false));
		}
	}
}
