using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class PageInfo
    {
        public PageInfo()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The total number of items
        /// </summary>
        public GraphQLQueryField TotalQueryField { get; private set; }

        /// <summary>
        /// The count on a page
        /// </summary>
        public GraphQLQueryField PerPageQueryField { get; private set; }

        /// <summary>
        /// The current page
        /// </summary>
        public GraphQLQueryField CurrentPageQueryField { get; private set; }

        /// <summary>
        /// The last page
        /// </summary>
        public GraphQLQueryField LastPageQueryField { get; private set; }

        /// <summary>
        /// If there is another page
        /// </summary>
        public GraphQLQueryField HasNextPageQueryField { get; private set; }

        private void InitializeProperties()
        {
            TotalQueryField = new GraphQLQueryField("total", new FieldRules(false));
            PerPageQueryField = new GraphQLQueryField("perPage", new FieldRules(false));
            CurrentPageQueryField = new GraphQLQueryField("currentPage", new FieldRules(false));
            LastPageQueryField = new GraphQLQueryField("lastPage", new FieldRules(false));
            HasNextPageQueryField = new GraphQLQueryField("hasNextPage", new FieldRules(false));
        }
    }
}
