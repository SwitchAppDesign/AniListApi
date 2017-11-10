using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class FuzzyDateInt
    {
        public FuzzyDateInt()
        {
            InitializeProperties();
        }

        public GraphQLQueryField FuzzyDateQueryField { get; private set; }

        private void InitializeProperties()
        {
            FuzzyDateQueryField = new GraphQLQueryField("FuzzyDate", new FieldRules(false));
        }
    }
}
