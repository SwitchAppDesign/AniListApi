using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class StudioEdge
    {
        public StudioEdge()
        {
            InitializeProperties();
        }

        public GraphQLQueryField NodeQueryField { get; private set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// If the studio is the main animation studio of the anime
        /// </summary>
        public GraphQLQueryField IsMainQueryField { get; private set; }

        /// <summary>
        /// The order the character should be displayed from the users favourites
        /// </summary>
        public GraphQLQueryField FavouriteOrderQueryField { get; private set; }

        private void InitializeProperties()
        {
            NodeQueryField = new GraphQLQueryField("node", new FieldRules(false));
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            IsMainQueryField = new GraphQLQueryField("isMain", new FieldRules(false));
            FavouriteOrderQueryField = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
        }
    }
}
