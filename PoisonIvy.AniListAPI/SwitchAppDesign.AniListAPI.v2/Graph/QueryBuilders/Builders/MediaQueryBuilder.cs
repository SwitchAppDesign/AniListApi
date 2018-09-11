using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderFields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders
{
    /// <summary>
    /// Builds a media graph query for the AniListAPI v2.
    /// </summary>
    public class MediaQueryBuilder : GraphQueryBuilder
    {
        /// <summary>
        /// The main fields for a media query.
        /// </summary>
        public MediaQueryFields MediaQueryFields { get; private set; }

        /// <summary>
        /// The main arguments for a media query.
        /// </summary>
        public MediaQueryArguments MediaQueryArguments { get; private set; }

        /// <summary>
        /// Access point for the media query fields.
        /// </summary>
        public MediaQueryBuilderFields OtherFields { get; private set; }

        /// <summary>
        /// Access point for all media query arguments.
        /// </summary>
        public MediaQueryBuilderArguments OtherArguments { get; private set; }

        internal MediaQueryBuilder()
        {
            InitializeBuilder(AniListQueryType.Media);
        }


        public MediaQueryBuilder(AniListQueryType queryType)
        {
            InitializeBuilder(queryType);
        }

        private void InitializeBuilder(AniListQueryType queryType)
        {
            InitializeBase(queryType);
                
            MediaQueryFields = new MediaQueryFields(queryType);
            MediaQueryArguments = new MediaQueryArguments(queryType);

            OtherFields = new MediaQueryBuilderFields(queryType);
            OtherArguments = new MediaQueryBuilderArguments(queryType);
        }
    }
}
