using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class UserOptions
    {
        public UserOptions()
        {
            InitializeProperties();
        }

        public GraphQLQueryField TitleLanguageQueryField { get; private set; }

        public GraphQLQueryField DisplayAdultContentQueryField { get; private set; }

        private void InitializeProperties()
        {
            TitleLanguageQueryField = new GraphQLQueryField("titleLanguage", new FieldRules(false));
            DisplayAdultContentQueryField = new GraphQLQueryField("displayAdultContent", new FieldRules(false));
        }
    }
}
