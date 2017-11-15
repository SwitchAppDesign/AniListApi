using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderFields;
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
        public static MediaQueryBuilderArguments CreateCustomerQueryBuider()
        {
            return new MediaQueryBuilderArguments();
        }

        /// <summary>
        /// Access point for the media query fields.
        /// </summary>
        public MediaQueryBuilderFields QueryFields { get; private set; }

        /// <summary>
        /// Access point for all media query arguments.
        /// </summary>
        public MediaQueryBuilderArguments QueryArguments { get; private set; }


        private void InitializeBuilder()
        {
            QueryFields = new MediaQueryBuilderFields();
            QueryArguments = new MediaQueryBuilderArguments();
        }
    }
}
