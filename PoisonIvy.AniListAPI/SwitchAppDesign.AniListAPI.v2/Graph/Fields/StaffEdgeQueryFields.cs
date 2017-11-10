using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class StaffEdge
    {
        public StaffEdge()
        {
            InitializeProperties();
        }

        public GraphQLQueryField NodeQueryField { get; private set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The role of the staff member in the production of the media
        /// </summary>
        public GraphQLQueryField RoleQueryField { get; private set; }

        /// <summary>
        /// The order the staff should be displayed from the users favourites
        /// </summary>
        public GraphQLQueryField FavouriteOrderQueryField { get; private set; }

        private void InitializeProperties()
        {
            NodeQueryField = new GraphQLQueryField("node", new FieldRules(false));
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            RoleQueryField = new GraphQLQueryField("role", new FieldRules(false));
            FavouriteOrderQueryField = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
        }
    }
}
