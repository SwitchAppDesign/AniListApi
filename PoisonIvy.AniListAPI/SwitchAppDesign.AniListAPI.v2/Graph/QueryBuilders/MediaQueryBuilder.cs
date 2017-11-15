using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderFields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders
{
    /// <summary>
    /// 
    /// </summary>
    public class MediaQueryBuilder : GraphQueryBuilder
    {
        internal MediaQueryBuilder()
        {
            InitializeBuilder();
        }

        /// <summary>
        /// Initilizes an new instance of <see cref="MediaQueryBuilder"/> for custom query building.
        /// </summary>
        /// <returns></returns>
        public static MediaQueryBuilder CreateCustomerQueryBuider()
        {
            return new MediaQueryBuilder();
        }

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


        private void InitializeBuilder()
        {
            InitializeBase(AniListQueryType.Media);
            GraphQueryFields = new List<GraphQueryField>();

            MediaQueryFields = new MediaQueryFields(AniListQueryType.Media);
            MediaQueryArguments = new MediaQueryArguments(AniListQueryType.Media);

            AdditionalAvailableFields = new MediaQueryBuilderFields();
            AdditionalAvailableArguments = new MediaQueryBuilderArguments();
        }
    }
}
