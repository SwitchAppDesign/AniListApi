using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available airing schedule query fields.
    /// </summary>
	public class AiringScheduleQueryFields
	{
		internal AiringScheduleQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the airing schedule item
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// Time the episode airs
		/// </summary>
		public GraphQueryField AiringAtQueryField()
		{
			return AiringAt;
		}

		/// <summary>
		/// Seconds until episode starts airing
		/// </summary>
		public GraphQueryField TimeUntilAiringQueryField()
		{
			return TimeUntilAiring;
		}

		/// <summary>
		/// The airing episode number
		/// </summary>
		public GraphQueryField EpisodeQueryField()
		{
			return Episode;
		}

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQueryField MediaIdQueryField()
		{
			return MediaId;
		}

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQueryField MediaQueryField()
		{
			return Media;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField AiringAt { get; set; }
		private GraphQueryField TimeUntilAiring { get; set; }
		private GraphQueryField Episode { get; set; }
		private GraphQueryField MediaId { get; set; }
		private GraphQueryField Media { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			AiringAt = new GraphQueryField("airingAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			TimeUntilAiring = new GraphQueryField("timeUntilAiring", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			Episode = new GraphQueryField("episode", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			MediaId = new GraphQueryField("mediaId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			Media = new GraphQueryField("media", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
		}
	}
}
