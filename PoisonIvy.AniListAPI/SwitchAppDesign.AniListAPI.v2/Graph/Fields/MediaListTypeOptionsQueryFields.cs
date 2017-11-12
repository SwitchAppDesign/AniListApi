using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListTypeOptionsQueryFields
	{
		public MediaListTypeOptionsQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField SectionOrderQueryField()
		{
			return SectionOrder;
		}

		public GraphQLQueryField SplitCompletedSectionByFormatQueryField()
		{
			return SplitCompletedSectionByFormat;
		}

		public GraphQLQueryField CustomListsQueryField()
		{
			return CustomLists;
		}

		public GraphQLQueryField AdvancedScoringQueryField()
		{
			return AdvancedScoring;
		}

		public GraphQLQueryField AdvancedScoringEnabledQueryField()
		{
			return AdvancedScoringEnabled;
		}

		private GraphQLQueryField SectionOrder { get; set; }
		private GraphQLQueryField SplitCompletedSectionByFormat { get; set; }
		private GraphQLQueryField CustomLists { get; set; }
		private GraphQLQueryField AdvancedScoring { get; set; }
		private GraphQLQueryField AdvancedScoringEnabled { get; set; }

		private void InitializeProperties()
		{
			SectionOrder = new GraphQLQueryField("sectionOrder", new FieldRules(false));
			SplitCompletedSectionByFormat = new GraphQLQueryField("splitCompletedSectionByFormat", new FieldRules(false));
			CustomLists = new GraphQLQueryField("customLists", new FieldRules(false));
			AdvancedScoring = new GraphQLQueryField("advancedScoring", new FieldRules(false));
			AdvancedScoringEnabled = new GraphQLQueryField("advancedScoringEnabled", new FieldRules(false));
		}
	}
}
