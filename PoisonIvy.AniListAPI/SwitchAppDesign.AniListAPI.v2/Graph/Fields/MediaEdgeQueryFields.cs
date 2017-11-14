using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaEdgeQueryFields
	{
		public MediaEdgeQueryFields(AniListQueryType queryType)
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
		/// The type of relation to the parent model
		/// </summary>
		public GraphQueryField RelationTypeQueryField()
		{
			return RelationType;
		}

		/// <summary>
		/// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
		/// </summary>
		public GraphQueryField IsMainStudioQueryField()
		{
			return IsMainStudio;
		}

		/// <summary>
		/// The characters in the media voiced by the parent actor
		/// </summary>
		public GraphQueryField CharactersQueryField()
		{
			return Characters;
		}

		/// <summary>
		/// The characters role in the media
		/// </summary>
		public GraphQueryField CharacterRoleQueryField()
		{
			return CharacterRole;
		}

		/// <summary>
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQueryField StaffRoleQueryField()
		{
			return StaffRole;
		}

		/// <summary>
		/// The voice actors of the character
		/// </summary>
		public GraphQueryField VoiceActorsQueryField()
		{
			return VoiceActors;
		}

		/// <summary>
		/// The order the media should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQueryField Node { get; set; }
		private GraphQueryField Id { get; set; }
		private GraphQueryField RelationType { get; set; }
		private GraphQueryField IsMainStudio { get; set; }
		private GraphQueryField Characters { get; set; }
		private GraphQueryField CharacterRole { get; set; }
		private GraphQueryField StaffRole { get; set; }
		private GraphQueryField VoiceActors { get; set; }
		private GraphQueryField FavouriteOrder { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			RelationType = new GraphQueryField("relationType", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsMainStudio = new GraphQueryField("isMainStudio", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Characters = new GraphQueryField("characters", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			CharacterRole = new GraphQueryField("characterRole", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			StaffRole = new GraphQueryField("staffRole", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			VoiceActors = new GraphQueryField("voiceActors", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
