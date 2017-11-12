using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringScheduleConnectionQueryFields
	{
		public AiringScheduleConnectionQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField EdgesQueryField()
		{
			return Edges;
		}

		public GraphQLQueryField NodesQueryField()
		{
			return Nodes;
		}

		public GraphQLQueryField PageInfoQueryField()
		{
			return PageInfo;
		}

		private GraphQLQueryField Edges { get; set; }
		private GraphQLQueryField Nodes { get; set; }
		private GraphQLQueryField PageInfo { get; set; }

		private void InitializeProperties()
		{
			Edges = new GraphQLQueryField("edges", new FieldRules(false));
			Nodes = new GraphQLQueryField("nodes", new FieldRules(false));
			PageInfo = new GraphQLQueryField("pageInfo", new FieldRules(false));
		}
	}
}
