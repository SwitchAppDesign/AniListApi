using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaListTypeOptions
    {
        public MediaListTypeOptions()
        {
            InitializeProperties();
        }

        public GraphQLQueryField SectionOrderQueryField { get; private set; }

        public GraphQLQueryField SplitCompletedSectionByFormatQueryField { get; private set; }

        public GraphQLQueryField CustomListsQueryField { get; private set; }

        public GraphQLQueryField AdvancedScoringQueryField { get; private set; }

        public GraphQLQueryField AdvancedScoringEnabledQueryField { get; private set; }

        private void InitializeProperties()
        {
            SectionOrderQueryField = new GraphQLQueryField("sectionOrder", new FieldRules(false));
            SplitCompletedSectionByFormatQueryField = new GraphQLQueryField("splitCompletedSectionByFormat", new FieldRules(false));
            CustomListsQueryField = new GraphQLQueryField("customLists", new FieldRules(false));
            AdvancedScoringQueryField = new GraphQLQueryField("advancedScoring", new FieldRules(false));
            AdvancedScoringEnabledQueryField = new GraphQLQueryField("advancedScoringEnabled", new FieldRules(false));
        }
    }
}
