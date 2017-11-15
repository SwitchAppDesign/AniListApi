using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available image data query fields.
    /// </summary>
	public class ImageDataQueryFields
	{
		internal ImageDataQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The image at its largest size
		/// </summary>
		public GraphQueryField LargeQueryField()
		{
			return Large;
		}

		/// <summary>
		/// The image of media at medium size
		/// </summary>
		public GraphQueryField MediumQueryField()
		{
			return Medium;
		}

		private GraphQueryField Large { get; set; }
		private GraphQueryField Medium { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Large = new GraphQueryField("large", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Medium = new GraphQueryField("medium", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
