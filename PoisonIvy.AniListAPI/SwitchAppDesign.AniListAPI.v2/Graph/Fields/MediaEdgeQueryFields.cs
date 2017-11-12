using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaEdgeQueryFields
	{
		public MediaEdgeQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField NodeQueryField()
		{
			return Node;
		}

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The type of relation to the parent model
		/// </summary>
		public GraphQLQueryField RelationTypeQueryField()
		{
			return RelationType;
		}

		/// <summary>
		/// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
		/// </summary>
		public GraphQLQueryField IsMainStudioQueryField()
		{
			return IsMainStudio;
		}

		/// <summary>
		/// The characters in the media voiced by the parent actor
		/// </summary>
		public GraphQLQueryField CharactersQueryField()
		{
			return Characters;
		}

		/// <summary>
		/// The characters role in the media
		/// </summary>
		public GraphQLQueryField CharacterRoleQueryField()
		{
			return CharacterRole;
		}

		/// <summary>
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQLQueryField StaffRoleQueryField()
		{
			return StaffRole;
		}

		/// <summary>
		/// The voice actors of the character
		/// </summary>
		public GraphQLQueryField VoiceActorsQueryField()
		{
			return VoiceActors;
		}

		/// <summary>
		/// The order the media should be displayed from the users favourites
		/// </summary>
		public GraphQLQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQLQueryField Node { get; set; }
		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField RelationType { get; set; }
		private GraphQLQueryField IsMainStudio { get; set; }
		private GraphQLQueryField Characters { get; set; }
		private GraphQLQueryField CharacterRole { get; set; }
		private GraphQLQueryField StaffRole { get; set; }
		private GraphQLQueryField VoiceActors { get; set; }
		private GraphQLQueryField FavouriteOrder { get; set; }

		private void InitializeProperties()
		{
			Node = new GraphQLQueryField("node", new FieldRules(false));
			Id = new GraphQLQueryField("id", new FieldRules(false));
			RelationType = new GraphQLQueryField("relationType", new FieldRules(false));
			IsMainStudio = new GraphQLQueryField("isMainStudio", new FieldRules(false));
			Characters = new GraphQLQueryField("characters", new FieldRules(false));
			CharacterRole = new GraphQLQueryField("characterRole", new FieldRules(false));
			StaffRole = new GraphQLQueryField("staffRole", new FieldRules(false));
			VoiceActors = new GraphQLQueryField("voiceActors", new FieldRules(false));
			FavouriteOrder = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
		}
	}
}
