using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class StatusDistribution
    {
        public StatusDistribution()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public GraphQLQueryField StatusQueryField { get; private set; }

        /// <summary>
        /// The amount of entries with this status
        /// </summary>
        public GraphQLQueryField AmountQueryField { get; private set; }

        private void InitializeProperties()
        {
            StatusQueryField = new GraphQLQueryField("status", new FieldRules(false));
            AmountQueryField = new GraphQLQueryField("amount", new FieldRules(false));
        }
    }
}
