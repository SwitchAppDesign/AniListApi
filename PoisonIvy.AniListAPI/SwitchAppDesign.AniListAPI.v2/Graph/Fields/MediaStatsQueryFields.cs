using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaStats
    {
        public MediaStats()
        {
            InitializeProperties();
        }

        public GraphQLQueryField ScoreDistributionQueryField { get; private set; }

        public GraphQLQueryField StatusDistributionQueryField { get; private set; }

        public GraphQLQueryField AiringProgressionQueryField { get; private set; }

        private void InitializeProperties()
        {
            ScoreDistributionQueryField = new GraphQLQueryField("scoreDistribution", new FieldRules(false));
            StatusDistributionQueryField = new GraphQLQueryField("statusDistribution", new FieldRules(false));
            AiringProgressionQueryField = new GraphQLQueryField("airingProgression", new FieldRules(false));
        }
    }
}
