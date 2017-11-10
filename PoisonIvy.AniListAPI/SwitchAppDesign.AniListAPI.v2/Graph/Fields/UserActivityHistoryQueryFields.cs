using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class UserActivityHistory
    {
        public UserActivityHistory()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public GraphQLQueryField DateQueryField { get; private set; }

        /// <summary>
        /// The amount of activity on the day
        /// </summary>
        public GraphQLQueryField AmountQueryField { get; private set; }

        /// <summary>
        /// The level of activity represented on a 1-10 scale
        /// </summary>
        public GraphQLQueryField LevelQueryField { get; private set; }

        private void InitializeProperties()
        {
            DateQueryField = new GraphQLQueryField("date", new FieldRules(false));
            AmountQueryField = new GraphQLQueryField("amount", new FieldRules(false));
            LevelQueryField = new GraphQLQueryField("level", new FieldRules(false));
        }
    }
}
