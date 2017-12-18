using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderArguments
{
    /// <summary>
    /// All available other arguments available for the page query
    /// </summary>
    public class PageQueryBuilderArguments
    {
        internal PageQueryBuilderArguments(AniListQueryType queryType)
        {
            InitializeArguments(queryType);
        }

        /// <summary>
        /// All available character connection query arguments.
        /// </summary>
        public CharacterConnectionQueryArguments CharacterConnection { get; private set; }

        /// <summary>
        /// All available character query arguments.
        /// </summary>
        public CharacterQueryArguments Character { get; private set; }

        /// <summary>
        /// All available staff connection query arguments
        /// </summary>
        public StaffConnectionQueryArguments StaffConnection { get; private set; }

        /// <summary>
        /// All available staff query arguments
        /// </summary>
        public StaffQueryArguments Staff { get; private set; }

        /// <summary>
        /// All available studio connection query arguments.
        /// </summary>
        public StudioConnectionQueryArguments StudioConnection { get; private set; }

        /// <summary>
        /// All available studio query arguments.
        /// </summary>
        public StudioQueryArguments Studio { get; private set; }

        /// <summary>
        /// All available airing schedule connection query arguments.
        /// </summary>
        public AiringScheduleConnectionQueryArguments AiringScheduleConnection { get; private set; }

        /// <summary>
        /// All available airing schedule query arguments.
        /// </summary>
        public AiringScheduleQueryArguments AiringSchedule { get; private set; }

        /// <summary>
        /// All available review query arguments.
        /// </summary>
        public ReviewConnectionQueryArguments ReviewConnection { get; private set; }

        /// <summary>
        /// All available review query arguments.
        /// </summary>
        public ReviewQueryArguments Review { get; private set; }

        private void InitializeArguments(AniListQueryType queryType)
        {
            CharacterConnection = new CharacterConnectionQueryArguments(queryType);
            Character = new CharacterQueryArguments(queryType);
            StaffConnection = new StaffConnectionQueryArguments(queryType);
            Staff = new StaffQueryArguments(queryType);
            StudioConnection = new StudioConnectionQueryArguments(queryType);
            Studio = new StudioQueryArguments(queryType);
            AiringScheduleConnection = new AiringScheduleConnectionQueryArguments(queryType);
            AiringSchedule = new AiringScheduleQueryArguments(queryType);
            ReviewConnection = new ReviewConnectionQueryArguments(queryType);
            Review = new ReviewQueryArguments(queryType);
        }
    }
}