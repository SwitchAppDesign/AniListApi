using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderFields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders
{
    /// <summary>
    /// Builds a page graph query for the AniListAPI v2
    /// </summary>
    public class PageQueryBuilder : GraphQueryBuilder
    {
        /// <summary>
        /// The main fields for a media query.
        /// </summary>
        public PageQueryFields PageQueryFields { get; private set; }

        /// <summary>
        /// The main arguments for a media query.
        /// </summary>
        public PageQueryArguments PageQueryArguments { get; private set; }

        /// <summary>
        /// Access point for the media query fields.
        /// </summary>
        public PageQueryBuilderFields OtherFields { get; private set; }

        /// <summary>
        /// Access point for all media query arguments.
        /// </summary>
        public PageQueryBuilderArguments OtherArguments { get; private set; }

        internal PageQueryBuilder()
        {
            InitializeBuilder(AniListQueryType.Page);
        }

        private void InitializeBuilder(AniListQueryType queryType)
        {
            InitializeBase(queryType);

            PageQueryFields = new PageQueryFields(queryType);
            PageQueryArguments = new PageQueryArguments(queryType);

            OtherFields = new PageQueryBuilderFields(queryType);
            OtherArguments = new PageQueryBuilderArguments(queryType);
        }
    }
}
