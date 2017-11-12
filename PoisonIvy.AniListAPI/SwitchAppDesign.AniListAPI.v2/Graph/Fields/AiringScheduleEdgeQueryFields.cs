using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringScheduleEdgeQueryFields
	{
		public AiringScheduleEdgeQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField NodeQueryField()
		{
			return Node;
		}

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		private GraphQLQueryField Node { get; set; }
		private GraphQLQueryField Id { get; set; }

		private void InitializeProperties()
		{
			Node = new GraphQLQueryField("node", new FieldRules(false));
			Id = new GraphQLQueryField("id", new FieldRules(false));
		}
	}
}
