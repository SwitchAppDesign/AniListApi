using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ParsedMarkdownQueryFields
	{
		public ParsedMarkdownQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField HtmlQueryField()
		{
			return Html;
		}

		private GraphQLQueryField Html { get; set; }

		private void InitializeProperties()
		{
			Html = new GraphQLQueryField("html", new FieldRules(false));
		}
	}
}
