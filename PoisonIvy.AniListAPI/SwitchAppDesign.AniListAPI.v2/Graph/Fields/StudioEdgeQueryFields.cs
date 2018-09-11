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
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public StudioEdgeQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Studio };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// <param name="fields">The list of studio query fields (found in <see cref="StudioQueryFields"/>) to be used in the graph query (at least of studio query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("node", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StudioQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(StudioQueryFields));

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
		/// If the studio is the main animation studio of the anime
		/// </summary>
		public GraphQueryField IsMainQueryField()
		{
		    return new GraphQueryField("isMain", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The order the character should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
			return new GraphQueryField("favouriteOrder", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
