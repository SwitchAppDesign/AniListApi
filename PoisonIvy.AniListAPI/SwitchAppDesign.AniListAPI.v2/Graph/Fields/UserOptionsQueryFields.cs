using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserOptionsQueryFields
	{
		public UserOptionsQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField TitleLanguageQueryField()
		{
			return TitleLanguage;
		}

		public GraphQLQueryField DisplayAdultContentQueryField()
		{
			return DisplayAdultContent;
		}

		private GraphQLQueryField TitleLanguage { get; set; }
		private GraphQLQueryField DisplayAdultContent { get; set; }

		private void InitializeProperties()
		{
			TitleLanguage = new GraphQLQueryField("titleLanguage", new FieldRules(false));
			DisplayAdultContent = new GraphQLQueryField("displayAdultContent", new FieldRules(false));
		}
	}
}
