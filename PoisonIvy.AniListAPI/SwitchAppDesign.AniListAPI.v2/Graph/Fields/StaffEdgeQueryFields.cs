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
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public StaffEdgeQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Staff, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// <param name="fields">The list of staff fields (found in <see cref="StaffQueryFields"/>) to be used in the graph query (at least of staff query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("node", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StaffQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQueryField RoleQueryField()
		{
		    return new GraphQueryField("role", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The order the staff should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
			return new GraphQueryField("favouriteOrder", GetType(), _queryType, InitilizeDefaultFieldRules());
		}
	}
}
