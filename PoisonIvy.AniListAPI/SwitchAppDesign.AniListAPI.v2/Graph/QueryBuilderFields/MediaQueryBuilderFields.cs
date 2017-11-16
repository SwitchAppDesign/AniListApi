using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderFields
{
    /// <summary>
    /// Entry point to the media query available fields and arguments. 
    /// Includes a reference to all related models available fields and arguments.
    /// </summary>
    public class MediaQueryBuilderFields
    {
        internal MediaQueryBuilderFields(AniListQueryType queryType)
        {
            InitializeFields(queryType);
        }

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public CharacterQueryFields CharacterQueryFields { get; private set; }

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public MediaTitleQueryFields MediaTitleQueryFields { get; private set; }

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public MediaTrailerQueryFields MediaTrailerQueryFields { get; private set; }

        /// <summary>
        /// All available cover image query fields.
        /// </summary>
        public ImageDataQueryFields CoverImageQueryFields { get; private set; }

        /// <summary>
        /// All available media tag query fields.
        /// </summary>
        public MediaTagQueryFields MediaTagQueryFields { get; private set; }

        /// <summary>
        /// All available media connection query fields.
        /// </summary>
        public MediaConnectionQueryFields MediaConnectionQueryFields { get; private set; }

        /// <summary>
        /// All available media edge query fields.
        /// </summary>
        public MediaEdgeQueryFields MediaEdgeQueryFields { get; private set; }

        /// <summary>
        /// All available page info query fields.
        /// </summary>
        public PageInfoQueryFields PagiInfoQueryFields { get; private set; }

        /// <summary>
        /// All available character connection query fields.
        /// </summary>
        public CharacterConnectionQueryFields CharacterConnectionQueryFields { get; private set; }

        /// <summary>
        /// All available character edge query fields.
        /// </summary>
        public CharacterEdgeQueryFields CharacterEdgeQueryFields { get; private set; }

        /// <summary>
        /// Staff connection query fields.
        /// </summary>
        public StaffConnectionQueryFields StaffConnectionQueryFields { get; private set; }

        /// <summary>
        /// All available staff query fields.
        /// </summary>
        public StaffQueryFields StaffQueryFields { get; private set; }

        /// <summary>
        /// All available staff edge query fields.
        /// </summary>
        public StaffEdgeQueryFields StaffEdgeQueryFields { get; private set; }

        /// <summary>
        /// All available staff connection query fields.
        /// </summary>
        public StudioConnectionQueryFields StudioConnectionQueryFields { get; private set; }

        /// <summary>
        /// All available studio edge query fields.
        /// </summary>
        public StudioEdgeQueryFields StudioEdgeQueryFields { get; private set; }

        /// <summary>
        /// All available studio query fields.
        /// </summary>
        public StudioQueryFields StudioQueryFields { get; private set; }

        /// <summary>
        /// All available airing schedule query fields.
        /// </summary>
        public AiringScheduleQueryFields AiringScheduleQueryFields { get; private set; }

        /// <summary>
        /// All available airing schedule connection query fields.
        /// </summary>
        public AiringScheduleConnectionQueryFields AiringScheduleConnectionQueryFields { get; private set; }

        /// <summary>
        /// All availabl airing schedule edge query fields.
        /// </summary>
        public AiringScheduleEdgeQueryFields AiringScheduleEdgeQueryFields { get; private set; }

        /// <summary>
        /// All available media external link query fields.
        /// </summary>
        public MediaExternalLinkQueryFields MediaExternalLinkQueryFields { get; private set; }

        /// <summary>
        /// All available streaming episode query fields.
        /// </summary>
        public MediaStreamingEpisodeQueryFields MediaStreamingEpisodeQueryFields { get; private set; }

        /// <summary>
        /// All available media rank query fields.
        /// </summary>
        public MediaRankQueryFields MediaRankQueryFields { get; private set; }

        /// <summary>
        /// All available media list query fields.
        /// </summary>
        public MediaListQueryFields MediaListQueryFields { get; private set; }

        /// <summary>
        /// All available review connection query fields.
        /// </summary>
        public ReviewConnectionQueryFields ReviewConnectionQueryFields { get; private set; }

        /// <summary>
        /// All available review edge query fields
        /// </summary>
        public ReviewEdgeQueryFields ReviewEdgeQueryFields { get; private set; }

        /// <summary>
        /// All available review query fields.
        /// </summary>
        public ReviewQueryFields ReviewQueryFields { get; private set; }

        /// <summary>
        /// All available media stats query fields.
        /// </summary>
        public MediaStatsQueryFields MediaStatsQueryFields { get; private set; }

        private void InitializeFields(AniListQueryType queryType)
        {
            CharacterQueryFields = new CharacterQueryFields(queryType);
            MediaTitleQueryFields = new MediaTitleQueryFields(queryType);
            MediaTrailerQueryFields = new MediaTrailerQueryFields(queryType);
            CoverImageQueryFields = new ImageDataQueryFields(queryType);
            MediaTagQueryFields = new MediaTagQueryFields(queryType);
            MediaConnectionQueryFields = new MediaConnectionQueryFields(queryType);
            MediaEdgeQueryFields = new MediaEdgeQueryFields(queryType);
            PagiInfoQueryFields = new PageInfoQueryFields(queryType);
            CharacterConnectionQueryFields = new CharacterConnectionQueryFields(queryType);
            CharacterEdgeQueryFields = new CharacterEdgeQueryFields(queryType);
            StaffConnectionQueryFields = new StaffConnectionQueryFields(queryType);
            StaffQueryFields = new StaffQueryFields(queryType);
            StaffEdgeQueryFields = new StaffEdgeQueryFields(queryType);
            StudioConnectionQueryFields = new StudioConnectionQueryFields(queryType);
            StudioEdgeQueryFields = new StudioEdgeQueryFields(queryType);
            StudioQueryFields = new StudioQueryFields(queryType);
            AiringScheduleQueryFields = new AiringScheduleQueryFields(queryType);
            AiringScheduleConnectionQueryFields = new AiringScheduleConnectionQueryFields(queryType);
            AiringScheduleEdgeQueryFields = new AiringScheduleEdgeQueryFields(queryType);
            MediaExternalLinkQueryFields = new MediaExternalLinkQueryFields(queryType);
            MediaStreamingEpisodeQueryFields = new MediaStreamingEpisodeQueryFields(queryType);
            MediaRankQueryFields = new MediaRankQueryFields(queryType);
            MediaListQueryFields = new MediaListQueryFields(queryType);
            ReviewConnectionQueryFields = new ReviewConnectionQueryFields(queryType);
            ReviewEdgeQueryFields = new ReviewEdgeQueryFields(queryType);
            ReviewQueryFields = new ReviewQueryFields(queryType);
            MediaStatsQueryFields = new MediaStatsQueryFields(queryType);
        }
    }
}
