using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaExternalLinkQueryFields
	{
		public MediaExternalLinkQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the external link
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The url of the external link
		/// </summary>
		public GraphQLQueryField UrlQueryField()
		{
			return Url;
		}

		/// <summary>
		/// The site location of the external link
		/// </summary>
		public GraphQLQueryField SiteQueryField()
		{
			return Site;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Url { get; set; }
		private GraphQLQueryField Site { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Url = new GraphQLQueryField("url", new FieldRules(false));
			Site = new GraphQLQueryField("site", new FieldRules(false));
		}
	}
}
