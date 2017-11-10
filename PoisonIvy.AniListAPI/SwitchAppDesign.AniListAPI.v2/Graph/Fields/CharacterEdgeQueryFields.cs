using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class CharacterEdge
	{
		public CharacterEdge()
		{
			InitializeProperties();
		}

		public GraphQLQueryField NodeQueryField { get; private set; }

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQLQueryField IdQueryField { get; private set; }

		/// <summary>
		/// The characters role in the media
		/// </summary>
		public GraphQLQueryField RoleQueryField { get; private set; }

		/// <summary>
		/// The voice actors of the character
		/// </summary>
		public GraphQLQueryField VoiceActorsQueryField { get; private set; }

		/// <summary>
		/// The media the character is in
		/// </summary>
		public GraphQLQueryField MediaQueryField { get; private set; }

		/// <summary>
		/// The order the character should be displayed from the users favourites
		/// </summary>
		public GraphQLQueryField FavouriteOrderQueryField { get; private set; }

		private void InitializeProperties()
		{
			NodeQueryField = new GraphQLQueryField("node", new FieldRules(false));
			IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
			RoleQueryField = new GraphQLQueryField("role", new FieldRules(false));
			VoiceActorsQueryField = new GraphQLQueryField("voiceActors", new FieldRules(false));
			MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
			FavouriteOrderQueryField = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
		}
	}
}
