using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderFields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries;
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
        public MediaQueryBuilderFields AdditionalAvailableFields { get; private set; }

        /// <summary>
        /// Access point for all media query arguments.
        /// </summary>
        public MediaQueryBuilderArguments AdditionalAvailableArguments { get; private set; }

        internal MediaQueryBuilder()
        {
            InitializeBuilder(AniListQueryType.Media);
        }

        internal MediaQueryBuilder(AniListQueryType queryType)
        {
            InitializeBuilder(queryType);
        }

        /// <summary>
        /// Initilizes an new instance of <see cref="MediaQueryBuilder"/> for custom query building.
        /// </summary>
        public static MediaQueryBuilder CreateCustomerQueryBuider(AniListQueryType queryType)
        {
            return new MediaQueryBuilder(queryType);
        }

        private void InitializeBuilder(AniListQueryType queryType)
        {
            InitializeBase(queryType);
                
            MediaQueryFields = new MediaQueryFields(queryType);
            MediaQueryArguments = new MediaQueryArguments(queryType);

            AdditionalAvailableFields = new MediaQueryBuilderFields(queryType);
            AdditionalAvailableArguments = new MediaQueryBuilderArguments(queryType);
        }
    }
}
