using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available page info query fields.
    /// </summary>
	public class PageInfoQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public PageInfoQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The total number of items
        /// </summary>
        public GraphQueryField TotalQueryField()
		{
		    return new GraphQueryField("total", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The count on a page
		/// </summary>
		public GraphQueryField PerPageQueryField()
		{
		    return new GraphQueryField("perPage", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The current page
		/// </summary>
		public GraphQueryField CurrentPageQueryField()
		{
		    return new GraphQueryField("currentPage", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The last page
		/// </summary>
		public GraphQueryField LastPageQueryField()
		{
		    return new GraphQueryField("lastPage", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// If there is another page
		/// </summary>
		public GraphQueryField HasNextPageQueryField()
		{
			return new GraphQueryField("hasNextPage", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
