using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class CharacterEdgeQueryFields
	{
		public CharacterEdgeQueryFields()
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
		/// The characters role in the media
		/// </summary>
		public GraphQLQueryField RoleQueryField()
		{
			return Role;
		}

		/// <summary>
		/// The voice actors of the character
		/// </summary>
		public GraphQLQueryField VoiceActorsQueryField()
		{
			return VoiceActors;
		}

		/// <summary>
		/// The media the character is in
		/// </summary>
		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		/// <summary>
		/// The order the character should be displayed from the users favourites
		/// </summary>
		public GraphQLQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQLQueryField Node { get; set; }
		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Role { get; set; }
		private GraphQLQueryField VoiceActors { get; set; }
		private GraphQLQueryField Media { get; set; }
		private GraphQLQueryField FavouriteOrder { get; set; }

		private void InitializeProperties()
		{
			Node = new GraphQLQueryField("node", new FieldRules(false));
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Role = new GraphQLQueryField("role", new FieldRules(false));
			VoiceActors = new GraphQLQueryField("voiceActors", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
			FavouriteOrder = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
		}
	}
}
