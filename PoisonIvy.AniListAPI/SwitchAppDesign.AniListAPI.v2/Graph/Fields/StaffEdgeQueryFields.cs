using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All staff edge query fields.
    /// </summary>
	public class StaffEdgeQueryFields
	{
		internal StaffEdgeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of staff fields (found in <see cref="StaffQueryFields"/>) to be used in the graph query (at least of staff query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Node.GetType().Name}) requires at least one staff query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StaffQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid staff query fields {fields.Where(x => x.ParentClassType != typeof(StaffQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

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
			Node = new GraphQueryField("node", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Role = new GraphQueryField("role", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
		}
	}
}
