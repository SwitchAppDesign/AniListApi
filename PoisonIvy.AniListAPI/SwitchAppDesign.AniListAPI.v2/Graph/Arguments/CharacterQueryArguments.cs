using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
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

        /// <summary>
        /// Filter by the role of the character.
        /// </summary>
        public GraphQLQueryArgument<CharacterRole> RoleQueryArgument(CharacterRole value)
        {
            return Role.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The page number.
        /// </summary>
        public GraphQLQueryArgument<int> PageQueryArgument(int value)
        {
            return Page.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The amount of entries per page (Max 25).
        /// </summary>
        public GraphQLQueryArgument<int> SortQueryArgument(int value)
        {
            return PerPage.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<string> Search { get; set; }
        private GraphQLQueryArgument<int> IdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<CharacterSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQLQueryArgument<CharacterRole> Role { get; set; }
        private GraphQLQueryArgument<int> Page { get; set; }
        private GraphQLQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Character }));
            Search = new GraphQLQueryArgument<string>("search", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Character }));
            IdNot = new GraphQLQueryArgument<int>("id_not", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Character }));
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Character }));
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Character }));
            Sort = new GraphQLQueryArgument<IEnumerable<CharacterSort>>("sort", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));

            Role = new GraphQLQueryArgument<CharacterRole>("role", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Page = new GraphQLQueryArgument<int>("page", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PerPage = new GraphQLQueryArgument<int>("perPage", new QueryArgumentRules(false, 25, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}