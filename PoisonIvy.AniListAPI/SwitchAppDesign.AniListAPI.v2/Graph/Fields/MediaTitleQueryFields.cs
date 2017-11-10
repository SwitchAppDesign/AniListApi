using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaTitle
    {
        public MediaTitle()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The romanization of the native language title
        /// </summary>
        public GraphQLQueryField RomajiQueryField { get; private set; }

        public GraphQLQueryField IsRomajiStylisedQueryField { get; private set; }

        /// <summary>
        /// The official english title
        /// </summary>
        public GraphQLQueryField EnglishQueryField { get; private set; }

        public GraphQLQueryField IsEnglishStylisedQueryField { get; private set; }

        /// <summary>
        /// Official title in it's native language
        /// </summary>
        public GraphQLQueryField NativeQueryField { get; private set; }

        public GraphQLQueryField IsNativeStylisedQueryField { get; private set; }

        /// <summary>
        /// The currently authenticated users preferred title language. Default romaji for non-authenticaed
        /// </summary>
        public GraphQLQueryField UserPreferredQueryField { get; private set; }

        private void InitializeProperties()
        {
            RomajiQueryField = new GraphQLQueryField("romaji", new FieldRules(false));
            IsRomajiStylisedQueryField = new GraphQLQueryField("IsRomajiStylised", new FieldRules(false));
            EnglishQueryField = new GraphQLQueryField("english", new FieldRules(false));
            IsEnglishStylisedQueryField = new GraphQLQueryField("IsEnglishStylised", new FieldRules(false));
            NativeQueryField = new GraphQLQueryField("native", new FieldRules(false));
            IsNativeStylisedQueryField = new GraphQLQueryField("IsNativeStylised", new FieldRules(false));
            UserPreferredQueryField = new GraphQLQueryField("userPreferred", new FieldRules(false));
        }
    }
}
