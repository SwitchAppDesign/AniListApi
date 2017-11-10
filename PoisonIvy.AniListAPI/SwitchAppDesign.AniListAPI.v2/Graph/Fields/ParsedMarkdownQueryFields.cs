using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ParsedMarkdown
    {
        public ParsedMarkdown()
        {
            InitializeProperties();
        }

        public GraphQLQueryField HtmlQueryField { get; private set; }

        private void InitializeProperties()
        {
            HtmlQueryField = new GraphQLQueryField("html", new FieldRules(false));
        }
    }
}
