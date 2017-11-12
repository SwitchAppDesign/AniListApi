using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FuzzyDateIntQueryFields
	{
		public FuzzyDateIntQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField FuzzyDateQueryField()
		{
			return FuzzyDate;
		}

		private GraphQLQueryField FuzzyDate { get; set; }

		private void InitializeProperties()
		{
			FuzzyDate = new GraphQLQueryField("FuzzyDate", new FieldRules(false));
		}
	}
}
