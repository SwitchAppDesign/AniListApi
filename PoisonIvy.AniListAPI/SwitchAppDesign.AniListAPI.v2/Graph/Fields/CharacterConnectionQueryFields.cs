using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class CharacterConnectionQueryFields
	{
		public CharacterConnectionQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField EdgesQueryField()
		{
			return Edges;
		}

		public GraphQueryField NodesQueryField()
		{
			return Nodes;
		}

		/// <summary>
		/// The pagination information
		/// </summary>
		public GraphQueryField PageInfoQueryField()
		{
			return PageInfo;
		}

		private GraphQueryField Edges { get; set; }
		private GraphQueryField Nodes { get; set; }
		private GraphQueryField PageInfo { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Edges = new GraphQueryField("edges", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			Nodes = new GraphQueryField("nodes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			PageInfo = new GraphQueryField("pageInfo", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
		}
	}
}
