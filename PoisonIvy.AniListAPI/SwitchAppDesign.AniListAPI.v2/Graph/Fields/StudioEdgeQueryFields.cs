using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StudioEdgeQueryFields
	{
		public StudioEdgeQueryFields()
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
		/// If the studio is the main animation studio of the anime
		/// </summary>
		public GraphQLQueryField IsMainQueryField()
		{
			return IsMain;
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
		private GraphQLQueryField IsMain { get; set; }
		private GraphQLQueryField FavouriteOrder { get; set; }

		private void InitializeProperties()
		{
			Node = new GraphQLQueryField("node", new FieldRules(false));
			Id = new GraphQLQueryField("id", new FieldRules(false));
			IsMain = new GraphQLQueryField("isMain", new FieldRules(false));
			FavouriteOrder = new GraphQLQueryField("favouriteOrder", new FieldRules(false));
		}
	}
}
