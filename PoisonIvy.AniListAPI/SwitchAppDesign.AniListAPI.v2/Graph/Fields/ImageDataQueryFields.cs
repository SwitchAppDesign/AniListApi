using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ImageDataQueryFields
	{
		public ImageDataQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The image at its largest size
		/// </summary>
		public GraphQLQueryField LargeQueryField()
		{
			return Large;
		}

		/// <summary>
		/// The cover image of media at medium size
		/// </summary>
		public GraphQLQueryField MediumQueryField()
		{
			return Medium;
		}

		private GraphQLQueryField Large { get; set; }
		private GraphQLQueryField Medium { get; set; }

		private void InitializeProperties()
		{
			Large = new GraphQLQueryField("large", new FieldRules(false));
			Medium = new GraphQLQueryField("medium", new FieldRules(false));
		}
	}
}
