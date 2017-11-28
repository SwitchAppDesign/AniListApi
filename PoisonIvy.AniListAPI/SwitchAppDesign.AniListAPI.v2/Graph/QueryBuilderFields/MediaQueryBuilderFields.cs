using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderFields
{
    /// <summary>
    /// All available other fields available for the media query
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
        public CharacterQueryFields Character { get; private set; }

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public MediaTitleQueryFields MediaTitle { get; private set; }

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public MediaTrailerQueryFields MediaTrailer { get; private set; }

        /// <summary>
        /// All available cover image query fields.
        /// </summary>
        public ImageDataQueryFields CoverImageData { get; private set; }

        /// <summary>
        /// All available media tag query fields.
        /// </summary>
        public MediaTagQueryFields MediaTag { get; private set; }

        /// <summary>
        /// All available media connection query fields.
        /// </summary>
        public MediaConnectionQueryFields MediaConnection { get; private set; }

        /// <summary>
        /// All available media edge query fields.
        /// </summary>
        public MediaEdgeQueryFields MediaEdge { get; private set; }

        /// <summary>
        /// All available page info query fields.
        /// </summary>
        public PageInfoQueryFields PagiInfoQuery { get; private set; }

        /// <summary>
        /// All available character connection query fields.
        /// </summary>
        public CharacterConnectionQueryFields CharacterConnection { get; private set; }

        /// <summary>
        /// All available character edge query fields.
        /// </summary>
        public CharacterEdgeQueryFields CharacterEdge { get; private set; }

        /// <summary>
        /// All available character edge query fields.
        /// </summary>
        public NameQueryFields Name { get; private set; }

        /// <summary>
        /// Staff connection query fields.
        /// </summary>
        public StaffConnectionQueryFields StaffConnection { get; private set; }

        /// <summary>
        /// All available staff query fields.
        /// </summary>
        public StaffQueryFields Staff { get; private set; }

        /// <summary>
        /// All available staff edge query fields.
        /// </summary>
        public StaffEdgeQueryFields StaffEdge { get; private set; }

        /// <summary>
        /// All available staff connection query fields.
        /// </summary>
        public StudioConnectionQueryFields StudioConnection { get; private set; }

        /// <summary>
        /// All available studio edge query fields.
        /// </summary>
        public StudioEdgeQueryFields StudioEdge { get; private set; }

        /// <summary>
        /// All available studio query fields.
        /// </summary>
        public StudioQueryFields Studio { get; private set; }

        /// <summary>
        /// All available airing schedule query fields.
        /// </summary>
        public AiringScheduleQueryFields AiringSchedule { get; private set; }

        /// <summary>
        /// All available airing schedule connection query fields.
        /// </summary>
        public AiringScheduleConnectionQueryFields AiringScheduleConnection { get; private set; }

        /// <summary>
        /// All availabl airing schedule edge query fields.
        /// </summary>
        public AiringScheduleEdgeQueryFields AiringScheduleEdge { get; private set; }

        /// <summary>
        /// All available media external link query fields.
        /// </summary>
        public MediaExternalLinkQueryFields MediaExternalLink { get; private set; }

        /// <summary>
        /// All available streaming episode query fields.
        /// </summary>
        public MediaStreamingEpisodeQueryFields MediaStreamingEpisode { get; private set; }

        /// <summary>
        /// All available media rank query fields.
        /// </summary>
        public MediaRankQueryFields MediaRank { get; private set; }

        /// <summary>
        /// All available media list query fields.
        /// </summary>
        public MediaListQueryFields MediaList { get; private set; }

        /// <summary>
        /// All available review connection query fields.
        /// </summary>
        public ReviewConnectionQueryFields ReviewConnection { get; private set; }

        /// <summary>
        /// All available review edge query fields
        /// </summary>
        public ReviewEdgeQueryFields ReviewEdge { get; private set; }

        /// <summary>
        /// All available review query fields.
        /// </summary>
        public ReviewQueryFields Review { get; private set; }

        /// <summary>
        /// All available media stats query fields.
        /// </summary>
        public MediaStatsQueryFields MediaStats { get; private set; }

        private void InitializeFields(AniListQueryType queryType)
        {
            Character = new CharacterQueryFields(queryType);
            MediaTitle = new MediaTitleQueryFields(queryType);
            MediaTrailer = new MediaTrailerQueryFields(queryType);
            CoverImageData = new ImageDataQueryFields(queryType);
            MediaTag = new MediaTagQueryFields(queryType);
            MediaConnection = new MediaConnectionQueryFields(queryType);
            MediaEdge = new MediaEdgeQueryFields(queryType);
            PagiInfoQuery = new PageInfoQueryFields(queryType);
            CharacterConnection = new CharacterConnectionQueryFields(queryType);
            CharacterEdge = new CharacterEdgeQueryFields(queryType);
            Name = new NameQueryFields(queryType);
            StaffConnection = new StaffConnectionQueryFields(queryType);
            Staff = new StaffQueryFields(queryType);
            StaffEdge = new StaffEdgeQueryFields(queryType);
            StudioConnection = new StudioConnectionQueryFields(queryType);
            StudioEdge = new StudioEdgeQueryFields(queryType);
            Studio = new StudioQueryFields(queryType);
            AiringSchedule = new AiringScheduleQueryFields(queryType);
            AiringScheduleConnection = new AiringScheduleConnectionQueryFields(queryType);
            AiringScheduleEdge = new AiringScheduleEdgeQueryFields(queryType);
            MediaExternalLink = new MediaExternalLinkQueryFields(queryType);
            MediaStreamingEpisode = new MediaStreamingEpisodeQueryFields(queryType);
            MediaRank = new MediaRankQueryFields(queryType);
            MediaList = new MediaListQueryFields(queryType);
            ReviewConnection = new ReviewConnectionQueryFields(queryType);
            ReviewEdge = new ReviewEdgeQueryFields(queryType);
            Review = new ReviewQueryFields(queryType);
            MediaStats = new MediaStatsQueryFields(queryType);
        }
    }
}
