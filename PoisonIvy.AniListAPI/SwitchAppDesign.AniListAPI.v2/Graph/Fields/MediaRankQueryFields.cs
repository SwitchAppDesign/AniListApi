using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media rank query fields.
    /// </summary>
	public class MediaRankQueryFields
	{
		internal MediaRankQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the rank
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The numerical rank of the media
		/// </summary>
		public GraphQueryField RankQueryField()
		{
			return Rank;
		}

		/// <summary>
		/// The type of ranking
		/// </summary>
		public GraphQueryField TypeQueryField()
		{
			return Type;
		}

		/// <summary>
		/// The format the media is ranked within
		/// </summary>
		public GraphQueryField FormatQueryField()
		{
			return Format;
		}

		/// <summary>
		/// The year the media is ranked within
		/// </summary>
		public GraphQueryField YearQueryField()
		{
			return Year;
		}

		/// <summary>
		/// The season the media is ranked within
		/// </summary>
		public GraphQueryField SeasonQueryField()
		{
			return Season;
		}

		/// <summary>
		/// If the ranking is based on all time instead of a season/year
		/// </summary>
		public GraphQueryField AllTimeQueryField()
		{
			return AllTime;
		}

		/// <summary>
		/// String that gives context to the ranking type and time span
		/// </summary>
		public GraphQueryField ContextQueryField()
		{
			return Context;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Rank { get; set; }
		private GraphQueryField Type { get; set; }
		private GraphQueryField Format { get; set; }
		private GraphQueryField Year { get; set; }
		private GraphQueryField Season { get; set; }
		private GraphQueryField AllTime { get; set; }
		private GraphQueryField Context { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Rank = new GraphQueryField("rank", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Type = new GraphQueryField("type", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Format = new GraphQueryField("format", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Year = new GraphQueryField("year", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Season = new GraphQueryField("season", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			AllTime = new GraphQueryField("allTime", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Context = new GraphQueryField("context", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
