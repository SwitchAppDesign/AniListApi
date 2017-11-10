using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ImageData
    {
        public ImageData()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The image at its largest size
        /// </summary>
        public GraphQLQueryField LargeQueryField { get; private set; }

        /// <summary>
        /// The cover image of media at medium size
        /// </summary>
        public GraphQLQueryField MediumQueryField { get; private set; }

        private void InitializeProperties()
        {
            LargeQueryField = new GraphQLQueryField("large", new FieldRules(false));
            MediumQueryField = new GraphQLQueryField("medium", new FieldRules(false));
        }
    }
}
