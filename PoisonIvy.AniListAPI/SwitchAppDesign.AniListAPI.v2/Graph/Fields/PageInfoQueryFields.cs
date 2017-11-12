using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class PageInfoQueryFields
	{
		public PageInfoQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The total number of items
		/// </summary>
		public GraphQLQueryField TotalQueryField()
		{
			return Total;
		}

		/// <summary>
		/// The count on a page
		/// </summary>
		public GraphQLQueryField PerPageQueryField()
		{
			return PerPage;
		}

		/// <summary>
		/// The current page
		/// </summary>
		public GraphQLQueryField CurrentPageQueryField()
		{
			return CurrentPage;
		}

		/// <summary>
		/// The last page
		/// </summary>
		public GraphQLQueryField LastPageQueryField()
		{
			return LastPage;
		}

		/// <summary>
		/// If there is another page
		/// </summary>
		public GraphQLQueryField HasNextPageQueryField()
		{
			return HasNextPage;
		}

		private GraphQLQueryField Total { get; set; }
		private GraphQLQueryField PerPage { get; set; }
		private GraphQLQueryField CurrentPage { get; set; }
		private GraphQLQueryField LastPage { get; set; }
		private GraphQLQueryField HasNextPage { get; set; }

		private void InitializeProperties()
		{
			Total = new GraphQLQueryField("total", new FieldRules(false));
			PerPage = new GraphQLQueryField("perPage", new FieldRules(false));
			CurrentPage = new GraphQLQueryField("currentPage", new FieldRules(false));
			LastPage = new GraphQLQueryField("lastPage", new FieldRules(false));
			HasNextPage = new GraphQLQueryField("hasNextPage", new FieldRules(false));
		}
	}
}
