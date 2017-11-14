using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ParsedMarkdownQueryFields
	{
		public ParsedMarkdownQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField HtmlQueryField()
		{
			return Html;
		}

		private GraphQueryField Html { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Html = new GraphQueryField("html", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Markdown }));
		}
	}
}
