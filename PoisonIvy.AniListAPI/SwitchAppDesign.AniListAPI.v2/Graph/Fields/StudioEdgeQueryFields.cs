using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StudioEdgeQueryFields
	{
		public StudioEdgeQueryFields(AniListQueryType queryType)
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
		/// If the studio is the main animation studio of the anime
		/// </summary>
		public GraphQueryField IsMainQueryField()
		{
			return IsMain;
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
		private GraphQueryField IsMain { get; set; }
		private GraphQueryField FavouriteOrder { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			IsMain = new GraphQueryField("isMain", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
		}
	}
}
