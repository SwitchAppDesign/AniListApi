using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ReviewEdge
    {
        public ReviewEdge()
        {
            InitializeProperties();
        }

        public GraphQLQueryField NodeQueryField { get; private set; }

        private void InitializeProperties()
        {
            NodeQueryField = new GraphQLQueryField("node", new FieldRules(false));
        }
    }
}
