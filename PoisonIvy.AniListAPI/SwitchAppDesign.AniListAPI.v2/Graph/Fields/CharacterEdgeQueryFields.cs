using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class CharacterEdgeQueryFields
	{
		public CharacterEdgeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField NodeQueryField()
		{
			return Node;
		}

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The characters role in the media
		/// </summary>
		public GraphQueryField RoleQueryField()
		{
			return Role;
		}

		/// <summary>
		/// The voice actors of the character
		/// </summary>
		public GraphQueryField VoiceActorsQueryField()
		{
			return VoiceActors;
		}

		/// <summary>
		/// The media the character is in
		/// </summary>
		public GraphQueryField MediaQueryField()
		{
			return Media;
		}

		/// <summary>
		/// The order the character should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQueryField Node { get; set; }
		private GraphQueryField Id { get; set; }
		private GraphQueryField Role { get; set; }
		private GraphQueryField VoiceActors { get; set; }
		private GraphQueryField Media { get; set; }
		private GraphQueryField FavouriteOrder { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			Role = new GraphQueryField("role", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			VoiceActors = new GraphQueryField("voiceActors", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			Media = new GraphQueryField("media", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User }));
		}
	}
}
