using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available studio edge query fields.
    /// </summary>
	public class StudioEdgeQueryFields
	{
		internal StudioEdgeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of studio query fields (found in <see cref="StudioQueryFields"/>) to be used in the graph query (at least of studio query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Node)}) requires at least one studio query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StudioQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid studio query fields {fields.Where(x => x.ParentClassType != typeof(StudioQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Node.GetGraphFieldAndSetFieldArguments(fields);
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
			Node = new GraphQueryField("node", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			IsMain = new GraphQueryField("isMain", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
		}
	}
}
