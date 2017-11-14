using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserOptionsQueryFields
	{
		public UserOptionsQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField TitleLanguageQueryField()
		{
			return TitleLanguage;
		}

		public GraphQueryField DisplayAdultContentQueryField()
		{
			return DisplayAdultContent;
		}

		private GraphQueryField TitleLanguage { get; set; }
		private GraphQueryField DisplayAdultContent { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			TitleLanguage = new GraphQueryField("titleLanguage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			DisplayAdultContent = new GraphQueryField("displayAdultContent", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
