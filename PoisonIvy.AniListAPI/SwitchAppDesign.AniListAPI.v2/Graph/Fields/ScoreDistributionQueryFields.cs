using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ScoreDistribution
    {
        public ScoreDistribution()
        {
            InitializeProperties();
        }

        public GraphQLQueryField ScoreQueryField { get; private set; }

        /// <summary>
        /// The amount of list entries with this score
        /// </summary>
        public GraphQLQueryField AmountQueryField { get; private set; }

        private void InitializeProperties()
        {
            ScoreQueryField = new GraphQLQueryField("score", new FieldRules(false));
            AmountQueryField = new GraphQLQueryField("amount", new FieldRules(false));
        }
    }
}
