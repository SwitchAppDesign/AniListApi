using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringScheduleQueryFields
	{
		public AiringScheduleQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the airing schedule item
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// Time the episode airs
		/// </summary>
		public GraphQLQueryField AiringAtQueryField()
		{
			return AiringAt;
		}

		/// <summary>
		/// Seconds until episode starts airing
		/// </summary>
		public GraphQLQueryField TimeUntilAiringQueryField()
		{
			return TimeUntilAiring;
		}

		/// <summary>
		/// The airing episode number
		/// </summary>
		public GraphQLQueryField EpisodeQueryField()
		{
			return Episode;
		}

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQLQueryField MediaIdQueryField()
		{
			return MediaId;
		}

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField AiringAt { get; set; }
		private GraphQLQueryField TimeUntilAiring { get; set; }
		private GraphQLQueryField Episode { get; set; }
		private GraphQLQueryField MediaId { get; set; }
		private GraphQLQueryField Media { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			AiringAt = new GraphQLQueryField("airingAt", new FieldRules(false));
			TimeUntilAiring = new GraphQLQueryField("timeUntilAiring", new FieldRules(false));
			Episode = new GraphQLQueryField("episode", new FieldRules(false));
			MediaId = new GraphQLQueryField("mediaId", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
		}
	}
}
