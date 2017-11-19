using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FuzzyDateIntQueryFields
	{
		public FuzzyDateIntQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField FuzzyDateQueryField()
		{
			return FuzzyDate;
		}

		private GraphQueryField FuzzyDate { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			FuzzyDate = new GraphQueryField("FuzzyDate", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
