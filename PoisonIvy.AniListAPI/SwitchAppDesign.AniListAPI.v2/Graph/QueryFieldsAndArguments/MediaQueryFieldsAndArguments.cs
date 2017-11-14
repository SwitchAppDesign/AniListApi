using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryFieldsAndArguments
{
    /// <summary>
    /// Entry point to the media query available fields and arguments. 
    /// Includes a reference to all related models available fields and arguments.
    /// </summary>
    public class MediaQueryFieldsAndArguments
    {
        internal MediaQueryFieldsAndArguments()
        {
            MediaQueryFields = new MediaQueryFields(AniListQueryType.Media);
            MediaQueryArguments = new MediaQueryArguments(AniListQueryType.Media);
        }

        /// <summary>
        /// All available media query fields.
        /// </summary>
        public MediaQueryFields MediaQueryFields { get; }

        /// <summary>
        /// All available media query arguments.
        /// </summary>
        public MediaQueryArguments MediaQueryArguments { get; }

        /// <summary>
        /// 
        /// </summary>
        public CharacterQueryFields CharacterQueryFields { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public CharacterQueryArguments CharacterQueryArguments { get; }
    }
}
