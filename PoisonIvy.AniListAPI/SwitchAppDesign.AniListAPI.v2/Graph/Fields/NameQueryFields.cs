using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available name query fields.
    /// </summary>
	public class NameQueryFields
	{
		internal NameQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField FirstQueryField()
		{
			return First;
		}

		public GraphQueryField LastQueryField()
		{
			return Last;
		}

		public GraphQueryField NativeQueryField()
		{
			return Native;
		}

		public GraphQueryField AlternativeQueryField()
		{
			return Alternative;
		}

		private GraphQueryField First { get; set; }
		private GraphQueryField Last { get; set; }
		private GraphQueryField Native { get; set; }
		private GraphQueryField Alternative { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			First = new GraphQueryField("first", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Last = new GraphQueryField("last", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Native = new GraphQueryField("native", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Alternative = new GraphQueryField("alternative", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
		}
	}
}
