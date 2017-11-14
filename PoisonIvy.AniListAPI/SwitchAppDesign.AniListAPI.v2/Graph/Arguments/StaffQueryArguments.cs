using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available staff query arguments.
    /// </summary>
    public class StaffQueryArguments
    {
        internal StaffQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the staff id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the staff id.
        /// </summary>
        public GraphQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the staff id.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the staff id.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> SortQueryArgument(IEnumerable<int> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The page number.
        /// </summary>
        public GraphQueryArgument<int> PageQueryArgument(int value)
        {
            return Page.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The amount of entries per page (Max 25).
        /// </summary>
        public GraphQueryArgument<int> SortQueryArgument(int value)
        {
            return PerPage.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<string> Search { get; set; }
        private GraphQueryArgument<int> IdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQueryArgument<int> Page { get; set; }
        private GraphQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Staff }));  
            Search = new GraphQueryArgument<string>("search", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Staff }));  
            IdNot = new GraphQueryArgument<int>("id_not", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Staff }));
            IdIn = new GraphQueryArgument<IEnumerable<int>>("id_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Staff })); 
            IdNotIn = new GraphQueryArgument<IEnumerable<int>>("id_not_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Staff }));
            Sort = new GraphQueryArgument<IEnumerable<int>>("sort", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Staff }));

            Page = new GraphQueryArgument<int>("page", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PerPage = new GraphQueryArgument<int>("perPage", queryType, new QueryArgumentRules(false, 25, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}