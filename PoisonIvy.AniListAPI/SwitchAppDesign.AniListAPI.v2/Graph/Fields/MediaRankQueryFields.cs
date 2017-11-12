using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaRankQueryFields
	{
		public MediaRankQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the rank
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The numerical rank of the media
		/// </summary>
		public GraphQLQueryField RankQueryField()
		{
			return Rank;
		}

		/// <summary>
		/// The type of ranking
		/// </summary>
		public GraphQLQueryField TypeQueryField()
		{
			return Type;
		}

		/// <summary>
		/// The format the media is ranked within
		/// </summary>
		public GraphQLQueryField FormatQueryField()
		{
			return Format;
		}

		/// <summary>
		/// The year the media is ranked within
		/// </summary>
		public GraphQLQueryField YearQueryField()
		{
			return Year;
		}

		/// <summary>
		/// The season the media is ranked within
		/// </summary>
		public GraphQLQueryField SeasonQueryField()
		{
			return Season;
		}

		/// <summary>
		/// If the ranking is based on all time instead of a season/year
		/// </summary>
		public GraphQLQueryField AllTimeQueryField()
		{
			return AllTime;
		}

		/// <summary>
		/// String that gives context to the ranking type and time span
		/// </summary>
		public GraphQLQueryField ContextQueryField()
		{
			return Context;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Rank { get; set; }
		private GraphQLQueryField Type { get; set; }
		private GraphQLQueryField Format { get; set; }
		private GraphQLQueryField Year { get; set; }
		private GraphQLQueryField Season { get; set; }
		private GraphQLQueryField AllTime { get; set; }
		private GraphQLQueryField Context { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Rank = new GraphQLQueryField("rank", new FieldRules(false));
			Type = new GraphQLQueryField("type", new FieldRules(false));
			Format = new GraphQLQueryField("format", new FieldRules(false));
			Year = new GraphQLQueryField("year", new FieldRules(false));
			Season = new GraphQLQueryField("season", new FieldRules(false));
			AllTime = new GraphQLQueryField("allTime", new FieldRules(false));
			Context = new GraphQLQueryField("context", new FieldRules(false));
		}
	}
}
