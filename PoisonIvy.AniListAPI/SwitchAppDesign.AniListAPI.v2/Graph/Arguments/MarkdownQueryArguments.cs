using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// Provide AniList markdown to be converted to html (Requires auth)
    /// </summary>
    public class MarkdownQueryArguments
    {
        internal MarkdownQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// The markdown to be parsed to html.
        /// </summary>
        public GraphQueryArgument<string> MarkdownQueryArgument(string value)
        {
            return Markdown.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<string> Markdown { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Markdown = new GraphQueryArgument<string>("markdown", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Markdown }));
        }
    }
}