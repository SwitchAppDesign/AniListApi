using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    internal class StudioQueryArguments
    {
        public StudioQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the studio id.
        /// </summary>
        private GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        private GraphQLQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not equal to the given value.
        /// </summary>
        private GraphQLQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not in the given collection.
        /// </summary>
        private GraphQLQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the studio id where id is not in the given collection.
        /// </summary>
        private GraphQLQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        private GraphQLQueryArgument<IEnumerable<StudioSort>> SortQueryArgument(IEnumerable<StudioSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<int> IdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<StudioSort>> Sort { get; set; }


        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            Search = new GraphQLQueryArgument<string>("search");
            IdNot = new GraphQLQueryArgument<int>("id_not");
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in");
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in");
            Sort = new GraphQLQueryArgument<IEnumerable<StudioSort>>("sort");
        }
    }
}