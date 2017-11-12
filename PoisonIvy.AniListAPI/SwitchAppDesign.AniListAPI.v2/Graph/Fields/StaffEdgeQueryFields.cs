using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StaffEdgeQueryFields
	{
		public StaffEdgeQueryFields()
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
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQLQueryField RoleQueryField()
		{
			return Role;
		}

		/// <summary>
		/// The order the staff should be displayed from the users favourites
		/// </summary>
		public GraphQLQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQLQueryField Node { get; set; }
		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Role { get; set; }
		private GraphQLQueryField FavouriteOrder { get; set; }

		private void InitializeProperties()
		{
			Node = new GraphQLQueryField("node", new FieldRules(false));
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Role = new GraphQLQueryField("role", new FieldRules(false));
			FavouriteOrder = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
		}
	}
}
