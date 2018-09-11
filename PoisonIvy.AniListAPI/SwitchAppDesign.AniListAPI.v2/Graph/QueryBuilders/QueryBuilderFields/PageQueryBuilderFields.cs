using System.Runtime.CompilerServices;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.QueryBuilderFields
{
    /// <summary>
    /// All other fields available for the page query
    /// </summary>
    public class PageQueryBuilderFields
    {
        private readonly AniListQueryType _queryType;

        internal PageQueryBuilderFields(AniListQueryType queryType)
        {
            _queryType = queryType;
        }

        /// <summary>
        /// All available media query fields.
        /// </summary>
        public MediaQueryFields Media => new MediaQueryFields(_queryType);

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public CharacterQueryFields Character => new CharacterQueryFields(_queryType);

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public MediaTitleQueryFields MediaTitle => new MediaTitleQueryFields(_queryType);

        /// <summary>
        /// All available character query fields.
        /// </summary>
        public MediaTrailerQueryFields MediaTrailer => new MediaTrailerQueryFields(_queryType);

        /// <summary>
        /// All available cover image query fields.
        /// </summary>
        public ImageDataQueryFields CoverImageData => new ImageDataQueryFields(_queryType);

        /// <summary>
        /// All available media tag query fields.
        /// </summary>
        public MediaTagQueryFields MediaTag => new MediaTagQueryFields(_queryType);

        /// <summary>
        /// All available media connection query fields.
        /// </summary>
        public MediaConnectionQueryFields MediaConnection => new MediaConnectionQueryFields(_queryType);

        /// <summary>
        /// All available media edge query fields.
        /// </summary>
        public MediaEdgeQueryFields MediaEdge => new MediaEdgeQueryFields(_queryType);

        /// <summary>
        /// All available page info query fields.
        /// </summary>
        public PageInfoQueryFields PagiInfoQuery => new PageInfoQueryFields(_queryType);

        /// <summary>
        /// All available character connection query fields.
        /// </summary>
        public CharacterConnectionQueryFields CharacterConnection => new CharacterConnectionQueryFields(_queryType);

        /// <summary>
        /// All available character edge query fields.
        /// </summary>
        public CharacterEdgeQueryFields CharacterEdge => new CharacterEdgeQueryFields(_queryType);

        /// <summary>
        /// All available character edge query fields.
        /// </summary>
        public NameQueryFields Name => new NameQueryFields(_queryType);

        /// <summary>
        /// Staff connection query fields.
        /// </summary>
        public StaffConnectionQueryFields StaffConnection => new StaffConnectionQueryFields(_queryType);

        /// <summary>
        /// All available staff query fields.
        /// </summary>
        public StaffQueryFields Staff => new StaffQueryFields(_queryType);

        /// <summary>
        /// All available staff edge query fields.
        /// </summary>
        public StaffEdgeQueryFields StaffEdge => new StaffEdgeQueryFields(_queryType);

        /// <summary>
        /// All available staff connection query fields.
        /// </summary>
        public StudioConnectionQueryFields StudioConnection => new StudioConnectionQueryFields(_queryType);

        /// <summary>
        /// All available studio edge query fields.
        /// </summary>
        public StudioEdgeQueryFields StudioEdge => new StudioEdgeQueryFields(_queryType);

        /// <summary>
        /// All available studio query fields.
        /// </summary>
        public StudioQueryFields Studio => new StudioQueryFields(_queryType);

        /// <summary>
        /// All available airing schedule query fields.
        /// </summary>
        public AiringScheduleQueryFields AiringSchedule => new AiringScheduleQueryFields(_queryType);

        /// <summary>
        /// All available airing schedule connection query fields.
        /// </summary>
        public AiringScheduleConnectionQueryFields AiringScheduleConnection => new AiringScheduleConnectionQueryFields(_queryType);

        /// <summary>
        /// All availabl airing schedule edge query fields.
        /// </summary>
        public AiringScheduleEdgeQueryFields AiringScheduleEdge => new AiringScheduleEdgeQueryFields(_queryType);

        /// <summary>
        /// All available media external link query fields.
        /// </summary>
        public MediaExternalLinkQueryFields MediaExternalLink => new MediaExternalLinkQueryFields(_queryType);

        /// <summary>
        /// All available streaming episode query fields.
        /// </summary>
        public MediaStreamingEpisodeQueryFields MediaStreamingEpisode => new MediaStreamingEpisodeQueryFields(_queryType);

        /// <summary>
        /// All available media rank query fields.
        /// </summary>
        public MediaRankQueryFields MediaRank => new MediaRankQueryFields(_queryType);

        /// <summary>
        /// All available media list query fields.
        /// </summary>
        public MediaListQueryFields MediaList => new MediaListQueryFields(_queryType);

        /// <summary>
        /// All available review connection query fields.
        /// </summary>
        public ReviewConnectionQueryFields ReviewConnection => new ReviewConnectionQueryFields(_queryType);

        /// <summary>
        /// All available review edge query fields
        /// </summary>
        public ReviewEdgeQueryFields ReviewEdge => new ReviewEdgeQueryFields(_queryType);

        /// <summary>
        /// All available review query fields.
        /// </summary>
        public ReviewQueryFields Review => new ReviewQueryFields(_queryType);

        /// <summary>
        /// All available media stats query fields.
        /// </summary>
        public MediaStatsQueryFields MediaStats => new MediaStatsQueryFields(_queryType);

    }
}