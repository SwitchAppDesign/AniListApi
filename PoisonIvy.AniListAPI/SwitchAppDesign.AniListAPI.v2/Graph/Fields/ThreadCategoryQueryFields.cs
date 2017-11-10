using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ThreadCategory
    {
        public ThreadCategory()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the category or media is of the media category.
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        public GraphQLQueryField NameQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            NameQueryField = new GraphQLQueryField("name", new FieldRules(false));
        }
    }
}
