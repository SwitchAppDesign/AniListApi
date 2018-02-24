using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
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
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Media)}) requires at least one media query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not media data query fields {fields.Where(x => x.ParentClassType != typeof(MediaQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Media.GetGraphFieldAndSetFieldArguments(fields);
        }

		private GraphQueryField Id { get; set; }
		private GraphQueryField AiringAt { get; set; }
		private GraphQueryField TimeUntilAiring { get; set; }
		private GraphQueryField Episode { get; set; }
		private GraphQueryField MediaId { get; set; }
		private GraphQueryField Media { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			AiringAt = new GraphQueryField("airingAt", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			TimeUntilAiring = new GraphQueryField("timeUntilAiring", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			Episode = new GraphQueryField("episode", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			MediaId = new GraphQueryField("mediaId", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
			Media = new GraphQueryField("media", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
		}
	}
}
