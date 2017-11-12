using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaTrailerQueryFields
	{
		public MediaTrailerQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The trailer video id
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The site the video is hosted by (Currently either youtube or dailymotion
		/// </summary>
		public GraphQLQueryField SiteQueryField()
		{
			return Site;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Site { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Site = new GraphQLQueryField("site", new FieldRules(false));
		}
	}
}
