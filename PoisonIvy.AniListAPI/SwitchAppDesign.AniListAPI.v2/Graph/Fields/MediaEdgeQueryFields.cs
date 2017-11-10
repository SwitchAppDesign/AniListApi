using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaEdge
    {
        public MediaEdge()
        {
            InitializeProperties();
        }

        public GraphQLQueryField NodeQueryField { get; private set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The type of relation to the parent model
        /// </summary>
        public GraphQLQueryField RelationTypeQueryField { get; private set; }

        /// <summary>
        /// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
        /// </summary>
        public GraphQLQueryField IsMainStudioQueryField { get; private set; }

        /// <summary>
        /// The characters in the media voiced by the parent actor
        /// </summary>
        public GraphQLQueryField CharactersQueryField { get; private set; }

        /// <summary>
        /// The characters role in the media
        /// </summary>
        public GraphQLQueryField CharacterRoleQueryField { get; private set; }

        /// <summary>
        /// The role of the staff member in the production of the media
        /// </summary>
        public GraphQLQueryField StaffRoleQueryField { get; private set; }

        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public GraphQLQueryField VoiceActorsQueryField { get; private set; }

        /// <summary>
        /// The order the media should be displayed from the users favourites
        /// </summary>
        public GraphQLQueryField FavouriteOrderQueryField { get; private set; }

        private void InitializeProperties()
        {
            NodeQueryField = new GraphQLQueryField("node", new FieldRules(false));
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            RelationTypeQueryField = new GraphQLQueryField("relationType", new FieldRules(false));
            IsMainStudioQueryField = new GraphQLQueryField("isMainStudio", new FieldRules(false));
            CharactersQueryField = new GraphQLQueryField("characters", new FieldRules(false));
            CharacterRoleQueryField = new GraphQLQueryField("characterRole", new FieldRules(false));
            StaffRoleQueryField = new GraphQLQueryField("staffRole", new FieldRules(false));
            VoiceActorsQueryField = new GraphQLQueryField("voiceActors", new FieldRules(false));
            FavouriteOrderQueryField = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
        }
    }
}
