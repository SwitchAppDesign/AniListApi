using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringSchedule
	{
		public AiringSchedule()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the airing schedule item
		/// </summary>
		public GraphQLQueryField IdQueryField { get; private set; }

		/// <summary>
		/// Time the episode airs
		/// </summary>
		public GraphQLQueryField AiringAtQueryField { get; private set; }

		/// <summary>
		/// Seconds until episode starts airing
		/// </summary>
		public GraphQLQueryField TimeUntilAiringQueryField { get; private set; }

		/// <summary>
		/// The airing episode number
		/// </summary>
		public GraphQLQueryField EpisodeQueryField { get; private set; }

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQLQueryField MediaIdQueryField { get; private set; }

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQLQueryField MediaQueryField { get; private set; }

		private void InitializeProperties()
		{
			IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
			AiringAtQueryField = new GraphQLQueryField("airingAt", new FieldRules(false));
			TimeUntilAiringQueryField = new GraphQLQueryField("timeUntilAiring", new FieldRules(false));
			EpisodeQueryField = new GraphQLQueryField("episode", new FieldRules(false));
			MediaIdQueryField = new GraphQLQueryField("mediaId", new FieldRules(false));
			MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
		}
	}
}
