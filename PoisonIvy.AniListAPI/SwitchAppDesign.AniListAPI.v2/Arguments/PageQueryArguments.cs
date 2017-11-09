using System;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    internal class PageQueryArguments
    {
        public PageQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The page.
        /// </summary>
        public GraphQLQueryArgument<int> PageQueryArgument(int value)
        {
            return Page.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The amount of entries per page, max 50
        /// </summary>
        public GraphQLQueryArgument<int> PerPageQueryArgument(int value)
        {
            return PerPage.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Page { get; set; }
        private GraphQLQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties()
        {
            Page = new GraphQLQueryArgument<int>("page");
            PerPage = new GraphQLQueryArgument<int>("perPage");
        }
    }
}
