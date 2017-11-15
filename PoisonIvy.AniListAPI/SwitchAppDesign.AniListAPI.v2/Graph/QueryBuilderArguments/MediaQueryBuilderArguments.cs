using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderArguments
{
    /// <summary>
    /// 
    /// </summary>
    public class MediaQueryBuilderArguments
    {
        internal MediaQueryBuilderArguments()
        {
            InitializeArguments();
        }

        /// <summary>
        /// All available character query arguments.
        /// </summary>
        public CharacterQueryArguments CharacterQueryArguments { get; private set; }

        /// <summary>
        /// All available staff query arguments
        /// </summary>
        public StaffQueryArguments StaffQueryArguments { get; private set; }

        /// <summary>
        /// All available studio query arguments.
        /// </summary>
        public StudioQueryArguments StudioQueryArguments { get; private set; }

        /// <summary>
        /// All available airing schedule query arguments.
        /// </summary>
        public AiringScheduleQueryArguments AiringScheduleQueryArguments { get; private set; }

        /// <summary>
        /// All available review query arguments.
        /// </summary>
        public ReviewQueryArguments ReviewQueryArguments { get; private set; }

        private void InitializeArguments()
        {
            CharacterQueryArguments = new CharacterQueryArguments(AniListQueryType.Media);
            StaffQueryArguments = new StaffQueryArguments(AniListQueryType.Media);
            StudioQueryArguments = new StudioQueryArguments(AniListQueryType.Media);
            AiringScheduleQueryArguments = new AiringScheduleQueryArguments(AniListQueryType.Media);
            ReviewQueryArguments = new ReviewQueryArguments(AniListQueryType.Media);
        }
    }
}