using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    /// <summary>
    /// Provide AniList markdown to be converted to html (Requires auth)
    /// </summary>
    internal class MarkdownQueryArguments
    {
        public MarkdownQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The markdown to be parsed to html.
        /// </summary>
        public GraphQLQueryArgument<string> MarkdownQueryArgument(string value)
        {
            return Markdown.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<string> Markdown { get; set; }

        private void InitializeProperties()
        {
            Markdown = new GraphQLQueryArgument<string>("markdown");
        }
    }
}