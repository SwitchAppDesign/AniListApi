using System;
using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media query fields.
    /// </summary>
	public class MediaQueryFields
	{
		internal MediaQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The mal id of the media
		/// </summary>
		public GraphQueryField IdMalQueryField()
		{
			return IdMal;
		}

		/// <summary>
		/// The official titles of the media in various languages
		/// </summary>
		public GraphQueryField TitleQueryField(IList<GraphQueryField> fields)
		{
		    if (fields != null && fields.Any())
		        throw new GraphQueryFieldInvalidException($"Field ({Reviews.GetType().Name}) requires at list one query field.");

            return Title.GetGraphFieldAndSetFieldArguments(fields);
		}

		/// <summary>
		/// The type of the media; anime or manga
		/// </summary>
		public GraphQueryField TypeQueryField()
		{
			return Type;
		}

		/// <summary>
		/// The format the media was released in
		/// </summary>
		public GraphQueryField FormatQueryField()
		{
			return Format;
		}

		/// <summary>
		/// The current releasing status of the media
		/// </summary>
		public GraphQueryField StatusQueryField()
		{
			return Status;
		}

		/// <summary>
		/// Short description of the media's story and characters
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// The first official release date of the media
		/// </summary>
		public GraphQueryField StartDateQueryField()
		{
			return StartDate;
		}

		/// <summary>
		/// The last official release date of the media
		/// </summary>
		public GraphQueryField EndDateQueryField()
		{
			return EndDate;
		}

		/// <summary>
		/// The season the media was initially released in
		/// </summary>
		public GraphQueryField SeasonQueryField()
		{
			return Season;
		}

		/// <summary>
		/// The amount of episodes the anime has when complete
		/// </summary>
		public GraphQueryField EpisodesQueryField()
		{
			return Episodes;
		}

		/// <summary>
		/// The general length of each anime episode in minutes
		/// </summary>
		public GraphQueryField DurationQueryField()
		{
			return Duration;
		}

		/// <summary>
		/// The amount of chapters the manga has when complete
		/// </summary>
		public GraphQueryField ChaptersQueryField()
		{
			return Chapters;
		}

		/// <summary>
		/// The amount of volumes the manga has when complete
		/// </summary>
		public GraphQueryField VolumesQueryField()
		{
			return Volumes;
		}

		/// <summary>
		/// Where the media was created. (ISO 3166-1 alpha-2)
		/// </summary>
		public GraphQueryField CountryOfOriginQueryField()
		{
			return CountryOfOrigin;
		}

		/// <summary>
		/// If the media is officially licensed or a self-published doujin release
		/// </summary>
		public GraphQueryField IsLicensedQueryField()
		{
			return IsLicensed;
		}

		/// <summary>
		/// Source type the media was adapted from.
		/// </summary>
		public GraphQueryField SourceQueryField()
		{
			return Source;
		}

		/// <summary>
		/// Official Twitter hashtags for the media
		/// </summary>
		public GraphQueryField HashtagQueryField()
		{
			return Hashtag;
		}

		/// <summary>
		/// Media trailer or advertisement
		/// </summary>
		public GraphQueryField TrailerQueryField()
		{
			return Trailer;
		}

		/// <summary>
		/// When the media's data was last updated
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// The cover images of the media
		/// </summary>
		public GraphQueryField CoverImageQueryField()
		{
			return CoverImage;
		}

		/// <summary>
		/// The banner image of the media
		/// </summary>
		public GraphQueryField BannerImageQueryField()
		{
			return BannerImage;
		}

		/// <summary>
		/// The genres of the media
		/// </summary>
		public GraphQueryField GenresQueryField()
		{
			return Genres;
		}

		/// <summary>
		/// Alternative titles of the media
		/// </summary>
		public GraphQueryField SynonymsQueryField()
		{
			return Synonyms;
		}

		/// <summary>
		/// A weighted average score of all the user's scores of the media
		/// </summary>
		public GraphQueryField AverageScoreQueryField()
		{
			return AverageScore;
		}

		/// <summary>
		/// Mean score of all the user's scores of the media
		/// </summary>
		public GraphQueryField MeanScoreQueryField()
		{
			return MeanScore;
		}

		/// <summary>
		/// The number of users with the media on their list
		/// </summary>
		public GraphQueryField PopularityQueryField()
		{
			return Popularity;
		}

		/// <summary>
		/// List of tags that describes elements and themes of the media
		/// </summary>
		public GraphQueryField TagsQueryField()
		{
			return Tags;
		}

		/// <summary>
		/// Other media in the same or connecting franchise
		/// </summary>
		public GraphQueryField RelationsQueryField()
		{
			return Relations;
		}

        /// <summary>
        /// The characters in the media. <see cref="string"/>
        /// <param name="fields">The list of character fields (found in CharacterQueryFields) to be used in the graph query.</param>
        /// <param name="arguments">The list of character arguments (found in CharacterQueryArguments) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed params</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>Role:</term><description>Role of the character.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// <see cref=""/>
        /// </list>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
        {
            if (fields != null && fields.Any())
                throw new GraphQueryFieldInvalidException($"Field ({Reviews.GetType().Name}) requires at list one query field.");

            if (arguments != null)
            {
                foreach (var argument in arguments)
                    argument.IsValidArgumentType();
            }

            return Characters.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

        /// <summary>
        /// The staff who produced the media
        /// <param name="fields">The list of staff fields (found in StaffQueryFields) to be used in the graph query.</param>
        /// <param name="arguments">The list of staff arguments (found in StaffQueryArguments) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField StaffQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    if (fields != null && fields.Any())
		        throw new GraphQueryFieldInvalidException($"Field ({Reviews.GetType().Name}) requires at list one query field.");

		    if (arguments != null)
		    {
		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return Staff.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

        /// <summary>
        /// The companies who produced the media
        /// <param name="fields">The list of studios fields (found in StudioQueryFields) to be used in the graph query.</param>
        /// <param name="arguments">The list of studios arguments (found in StudioQueryArguments) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>IsMain:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields, IList<GraphQueryArgument<object>> arguments = null)
		{
		    if (fields != null && fields.Any())
		        throw new GraphQueryFieldInvalidException($"Field ({Reviews.GetType().Name}) requires at list one query field.");

		    if (arguments != null)
		    {
		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return Studios.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

		/// <summary>
		/// If the media is marked as favourite by the current authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// If the media is intended only for 18+ adult audiences
		/// </summary>
		public GraphQueryField IsAdultQueryField()
		{
			return IsAdult;
		}

		/// <summary>
		/// The media's next episode airing schedule
		/// </summary>
		public GraphQueryField NextAiringEpisodeQueryField()
		{
			return NextAiringEpisode;
		}

        /// <summary>
        /// The media's entire airing schedule
        /// <param name="fields">The list of airing schedule fields (found in AiringScheduleQueryFields) to be used in the graph query.</param>
        /// <param name="arguments">The list of airing schedule arguments (found in AiringScheduleQueryArguments) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>NotYetAired:</term><description>Whether the media has airing or not.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField AiringScheduleQueryField(IList<GraphQueryField> fields, IList<GraphQueryArgument<object>> arguments = null)
		{
		    if (fields != null && fields.Any())
		        throw new GraphQueryFieldInvalidException($"Field ({Reviews.GetType().Name}) requires at list one query field.");

            return AiringSchedule.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

		/// <summary>
		/// External links to another site related to the media
		/// </summary>
		public GraphQueryField ExternalLinksQueryField()
		{
			return ExternalLinks;
		}

		/// <summary>
		/// Data and links to legal streaming episodes on external sites
		/// </summary>
		public GraphQueryField StreamingEpisodesQueryField()
		{
			return StreamingEpisodes;
		}

		/// <summary>
		/// The ranking of the media in a particular time span and format compared to other media
		/// </summary>
		public GraphQueryField RankingsQueryField()
		{
			return Rankings;
		}

		/// <summary>
		/// The authenticated user's media list entry for the media
		/// </summary>
		public GraphQueryField MediaListEntryQueryField()
		{
			return MediaListEntry;
		}

        /// <summary>
        /// User reviews of the media
        /// <param name="fields">The list of review fields (found in ReviewQueryFields) to be used in the graph query.</param>
        /// <param name="arguments">The list of review arguments (found in ReviewQueryArguments) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Limit:</term><description>The review limit.</description></item>
        /// <item><term>Sort:</term><description> The fields to sort by.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField ReviewsQueryField(IList<GraphQueryField> fields, IList<GraphQueryArgument<object>> arguments = null)
		{
            if (fields != null && fields.Any())
                throw new GraphQueryFieldInvalidException($"Field ({Reviews.GetType().Name}) requires at list one query field.");

		    if (arguments != null)
		    {
		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return Reviews.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

		public GraphQueryField StatsQueryField()
		{
			return Stats;
		}

		/// <summary>
		/// The url for the media page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// If the media should have forum thread automatically created for it on airing episode release
		/// </summary>
		public GraphQueryField AutoCreateForumThreadQueryField()
		{
			return AutoCreateForumThread;
		}

		/// <summary>
		/// Notes for site moderators
		/// </summary>
		public GraphQueryField ModNotesQueryField()
		{
			return ModNotes;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField IdMal { get; set; }
		private GraphQueryField Title { get; set; }
		private GraphQueryField Type { get; set; }
		private GraphQueryField Format { get; set; }
		private GraphQueryField Status { get; set; }
		private GraphQueryField Description { get; set; }
		private GraphQueryField StartDate { get; set; }
		private GraphQueryField EndDate { get; set; }
		private GraphQueryField Season { get; set; }
		private GraphQueryField Episodes { get; set; }
		private GraphQueryField Duration { get; set; }
		private GraphQueryField Chapters { get; set; }
		private GraphQueryField Volumes { get; set; }
		private GraphQueryField CountryOfOrigin { get; set; }
		private GraphQueryField IsLicensed { get; set; }
		private GraphQueryField Source { get; set; }
		private GraphQueryField Hashtag { get; set; }
		private GraphQueryField Trailer { get; set; }
		private GraphQueryField UpdatedAt { get; set; }
		private GraphQueryField CoverImage { get; set; }
		private GraphQueryField BannerImage { get; set; }
		private GraphQueryField Genres { get; set; }
		private GraphQueryField Synonyms { get; set; }
		private GraphQueryField AverageScore { get; set; }
		private GraphQueryField MeanScore { get; set; }
		private GraphQueryField Popularity { get; set; }
		private GraphQueryField Tags { get; set; }
		private GraphQueryField Relations { get; set; }
		private GraphQueryField Characters { get; set; }
		private GraphQueryField Staff { get; set; }
		private GraphQueryField Studios { get; set; }
		private GraphQueryField IsFavourite { get; set; }
		private GraphQueryField IsAdult { get; set; }
		private GraphQueryField NextAiringEpisode { get; set; }
		private GraphQueryField AiringSchedule { get; set; }
		private GraphQueryField ExternalLinks { get; set; }
		private GraphQueryField StreamingEpisodes { get; set; }
		private GraphQueryField Rankings { get; set; }
		private GraphQueryField MediaListEntry { get; set; }
		private GraphQueryField Reviews { get; set; }
		private GraphQueryField Stats { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField AutoCreateForumThread { get; set; }
		private GraphQueryField ModNotes { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IdMal = new GraphQueryField("idMal", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Title = new GraphQueryField("title", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Type = new GraphQueryField("type", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Format = new GraphQueryField("format", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Status = new GraphQueryField("status", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Description = new GraphQueryField("description", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			StartDate = new GraphQueryField("startDate", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			EndDate = new GraphQueryField("endDate", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Season = new GraphQueryField("season", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Episodes = new GraphQueryField("episodes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Duration = new GraphQueryField("duration", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Chapters = new GraphQueryField("chapters", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Volumes = new GraphQueryField("volumes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			CountryOfOrigin = new GraphQueryField("countryOfOrigin", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsLicensed = new GraphQueryField("isLicensed", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Source = new GraphQueryField("source", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Hashtag = new GraphQueryField("hashtag", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Trailer = new GraphQueryField("trailer", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			UpdatedAt = new GraphQueryField("updatedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			CoverImage = new GraphQueryField("coverImage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			BannerImage = new GraphQueryField("bannerImage", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Genres = new GraphQueryField("genres", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Synonyms = new GraphQueryField("synonyms", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			AverageScore = new GraphQueryField("averageScore", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			MeanScore = new GraphQueryField("meanScore", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Popularity = new GraphQueryField("popularity", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Tags = new GraphQueryField("tags", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Relations = new GraphQueryField("relations", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Characters = new GraphQueryField("characters", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Staff = new GraphQueryField("staff", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Studios = new GraphQueryField("studios", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsFavourite = new GraphQueryField("isFavourite", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsAdult = new GraphQueryField("isAdult", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			NextAiringEpisode = new GraphQueryField("nextAiringEpisode", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			AiringSchedule = new GraphQueryField("airingSchedule", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			ExternalLinks = new GraphQueryField("externalLinks", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			StreamingEpisodes = new GraphQueryField("streamingEpisodes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Rankings = new GraphQueryField("rankings", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			MediaListEntry = new GraphQueryField("mediaListEntry", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Reviews = new GraphQueryField("reviews", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Stats = new GraphQueryField("stats", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			AutoCreateForumThread = new GraphQueryField("autoCreateForumThread", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			ModNotes = new GraphQueryField("modNotes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
