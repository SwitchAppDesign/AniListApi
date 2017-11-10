using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class CharacterQueryArguments
    {
        public CharacterQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by character id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by search query.
        /// </summary>
        public GraphQLQueryArgument<string> SearchQueryArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by character id where id is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by character id where id is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by character id where id is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<CharacterSort>> SortQueryArgument(IEnumerable<CharacterSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<int> IdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<CharacterSort>> Sort { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            Search = new GraphQLQueryArgument<string>("search");
            IdNot = new GraphQLQueryArgument<int>("id_not");
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in");
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in");
            Sort = new GraphQLQueryArgument<IEnumerable<CharacterSort>>("sort");
        }
    }
}