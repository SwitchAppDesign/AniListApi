using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListTypeOptionsQueryFields
	{
		public MediaListTypeOptionsQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField SectionOrderQueryField()
		{
			return SectionOrder;
		}

		public GraphQueryField SplitCompletedSectionByFormatQueryField()
		{
			return SplitCompletedSectionByFormat;
		}

		public GraphQueryField CustomListsQueryField()
		{
			return CustomLists;
		}

		public GraphQueryField AdvancedScoringQueryField()
		{
			return AdvancedScoring;
		}

		public GraphQueryField AdvancedScoringEnabledQueryField()
		{
			return AdvancedScoringEnabled;
		}

		private GraphQueryField SectionOrder { get; set; }
		private GraphQueryField SplitCompletedSectionByFormat { get; set; }
		private GraphQueryField CustomLists { get; set; }
		private GraphQueryField AdvancedScoring { get; set; }
		private GraphQueryField AdvancedScoringEnabled { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			SectionOrder = new GraphQueryField("sectionOrder", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			SplitCompletedSectionByFormat = new GraphQueryField("splitCompletedSectionByFormat", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			CustomLists = new GraphQueryField("customLists", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			AdvancedScoring = new GraphQueryField("advancedScoring", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			AdvancedScoringEnabled = new GraphQueryField("advancedScoringEnabled", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
		}
	}
}
