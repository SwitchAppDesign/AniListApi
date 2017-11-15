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
		internal PageInfoQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The total number of items
		/// </summary>
		public GraphQueryField TotalQueryField()
		{
			return Total;
		}

		/// <summary>
		/// The count on a page
		/// </summary>
		public GraphQueryField PerPageQueryField()
		{
			return PerPage;
		}

		/// <summary>
		/// The current page
		/// </summary>
		public GraphQueryField CurrentPageQueryField()
		{
			return CurrentPage;
		}

		/// <summary>
		/// The last page
		/// </summary>
		public GraphQueryField LastPageQueryField()
		{
			return LastPage;
		}

		/// <summary>
		/// If there is another page
		/// </summary>
		public GraphQueryField HasNextPageQueryField()
		{
			return HasNextPage;
		}

		private GraphQueryField Total { get; set; }
		private GraphQueryField PerPage { get; set; }
		private GraphQueryField CurrentPage { get; set; }
		private GraphQueryField LastPage { get; set; }
		private GraphQueryField HasNextPage { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Total = new GraphQueryField("total", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			PerPage = new GraphQueryField("perPage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			CurrentPage = new GraphQueryField("currentPage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			LastPage = new GraphQueryField("lastPage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
			HasNextPage = new GraphQueryField("hasNextPage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Page }));
		}
	}
}
