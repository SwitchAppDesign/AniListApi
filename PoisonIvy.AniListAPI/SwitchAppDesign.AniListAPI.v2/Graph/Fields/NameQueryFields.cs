using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Name
    {
        public Name()
        {
            InitializeProperties();
        }

        public GraphQLQueryField FirstQueryField { get; private set; }

        public GraphQLQueryField LastQueryField { get; private set; }

        public GraphQLQueryField NativeQueryField { get; private set; }

        public GraphQLQueryField AlternativeQueryField { get; private set; }

        private void InitializeProperties()
        {
            FirstQueryField = new GraphQLQueryField("first", new FieldRules(false));
            LastQueryField = new GraphQLQueryField("last", new FieldRules(false));
            NativeQueryField = new GraphQLQueryField("native", new FieldRules(false));
            AlternativeQueryField = new GraphQLQueryField("alternative", new FieldRules(false));
        }
    }
}
