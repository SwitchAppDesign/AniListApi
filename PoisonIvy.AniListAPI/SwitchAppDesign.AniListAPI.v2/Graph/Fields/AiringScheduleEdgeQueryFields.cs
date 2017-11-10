using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringScheduleEdge
	{
		public AiringScheduleEdge()
		{
			InitializeProperties();
		}

		public GraphQLQueryField NodeQueryField { get; private set; }

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQLQueryField IdQueryField { get; private set; }

		private void InitializeProperties()
		{
			NodeQueryField = new GraphQLQueryField("node", new FieldRules(false));
			IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
		}
	}
}
