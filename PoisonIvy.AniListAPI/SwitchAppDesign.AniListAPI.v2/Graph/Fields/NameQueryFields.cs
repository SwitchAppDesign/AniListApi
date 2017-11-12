using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class NameQueryFields
	{
		public NameQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField FirstQueryField()
		{
			return First;
		}

		public GraphQLQueryField LastQueryField()
		{
			return Last;
		}

		public GraphQLQueryField NativeQueryField()
		{
			return Native;
		}

		public GraphQLQueryField AlternativeQueryField()
		{
			return Alternative;
		}

		private GraphQLQueryField First { get; set; }
		private GraphQLQueryField Last { get; set; }
		private GraphQLQueryField Native { get; set; }
		private GraphQLQueryField Alternative { get; set; }

		private void InitializeProperties()
		{
			First = new GraphQLQueryField("first", new FieldRules(false));
			Last = new GraphQLQueryField("last", new FieldRules(false));
			Native = new GraphQLQueryField("native", new FieldRules(false));
			Alternative = new GraphQLQueryField("alternative", new FieldRules(false));
		}
	}
}
