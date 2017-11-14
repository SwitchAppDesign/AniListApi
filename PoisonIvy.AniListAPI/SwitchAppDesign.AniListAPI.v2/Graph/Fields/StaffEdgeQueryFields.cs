using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StaffEdgeQueryFields
	{
		public StaffEdgeQueryFields(AniListQueryType queryType)
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
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQueryField RoleQueryField()
		{
			return Role;
		}

		/// <summary>
		/// The order the staff should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQueryField Node { get; set; }
		private GraphQueryField Id { get; set; }
		private GraphQueryField Role { get; set; }
		private GraphQueryField FavouriteOrder { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Role = new GraphQueryField("role", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
		}
	}
}
