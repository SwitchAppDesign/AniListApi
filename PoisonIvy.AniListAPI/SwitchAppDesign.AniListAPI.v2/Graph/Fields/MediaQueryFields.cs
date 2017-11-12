using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Transactions;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaQueryFields
	{
		public MediaQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The mal id of the media
		/// </summary>
		public GraphQLQueryField IdMalQueryField()
		{
			return IdMal;
		}

		/// <summary>
		/// The official titles of the media in various languages
		/// </summary>
		public GraphQLQueryField TitleQueryField()
		{
			return Title;
		}

		/// <summary>
		/// The type of the media; anime or manga
		/// </summary>
		public GraphQLQueryField TypeQueryField()
		{
			return Type;
		}

		/// <summary>
		/// The format the media was released in
		/// </summary>
		public GraphQLQueryField FormatQueryField()
		{
			return Format;
		}

		/// <summary>
		/// The current releasing status of the media
		/// </summary>
		public GraphQLQueryField StatusQueryField()
		{
			return Status;
		}

		/// <summary>
		/// Short description of the media's story and characters
		/// </summary>
		public GraphQLQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// The first official release date of the media
		/// </summary>
		public GraphQLQueryField StartDateQueryField()
		{
			return StartDate;
		}

		/// <summary>
		/// The last official release date of the media
		/// </summary>
		public GraphQLQueryField EndDateQueryField()
		{
			return EndDate;
		}

		/// <summary>
		/// The season the media was initially released in
		/// </summary>
		public GraphQLQueryField SeasonQueryField()
		{
			return Season;
		}

		/// <summary>
		/// The amount of episodes the anime has when complete
		/// </summary>
		public GraphQLQueryField EpisodesQueryField()
		{
			return Episodes;
		}

		/// <summary>
		/// The general length of each anime episode in minutes
		/// </summary>
		public GraphQLQueryField DurationQueryField()
		{
			return Duration;
		}

		/// <summary>
		/// The amount of chapters the manga has when complete
		/// </summary>
		public GraphQLQueryField ChaptersQueryField()
		{
			return Chapters;
		}

		/// <summary>
		/// The amount of volumes the manga has when complete
		/// </summary>
		public GraphQLQueryField VolumesQueryField()
		{
			return Volumes;
		}

		/// <summary>
		/// Where the media was created. (ISO 3166-1 alpha-2)
		/// </summary>
		public GraphQLQueryField CountryOfOriginQueryField()
		{
			return CountryOfOrigin;
		}

		/// <summary>
		/// If the media is officially licensed or a self-published doujin release
		/// </summary>
		public GraphQLQueryField IsLicensedQueryField()
		{
			return IsLicensed;
		}

		/// <summary>
		/// Source type the media was adapted from.
		/// </summary>
		public GraphQLQueryField SourceQueryField()
		{
			return Source;
		}

		/// <summary>
		/// Official Twitter hashtags for the media
		/// </summary>
		public GraphQLQueryField HashtagQueryField()
		{
			return Hashtag;
		}

		/// <summary>
		/// Media trailer or advertisement
		/// </summary>
		public GraphQLQueryField TrailerQueryField()
		{
			return Trailer;
		}

		/// <summary>
		/// When the media's data was last updated
		/// </summary>
		public GraphQLQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// The cover images of the media
		/// </summary>
		public GraphQLQueryField CoverImageQueryField()
		{
			return CoverImage;
		}

		/// <summary>
		/// The banner image of the media
		/// </summary>
		public GraphQLQueryField BannerImageQueryField()
		{
			return BannerImage;
		}

		/// <summary>
		/// The genres of the media
		/// </summary>
		public GraphQLQueryField GenresQueryField()
		{
			return Genres;
		}

		/// <summary>
		/// Alternative titles of the media
		/// </summary>
		public GraphQLQueryField SynonymsQueryField()
		{
			return Synonyms;
		}

		/// <summary>
		/// A weighted average score of all the user's scores of the media
		/// </summary>
		public GraphQLQueryField AverageScoreQueryField()
		{
			return AverageScore;
		}

		/// <summary>
		/// Mean score of all the user's scores of the media
		/// </summary>
		public GraphQLQueryField MeanScoreQueryField()
		{
			return MeanScore;
		}

		/// <summary>
		/// The number of users with the media on their list
		/// </summary>
		public GraphQLQueryField PopularityQueryField()
		{
			return Popularity;
		}

		/// <summary>
		/// List of tags that describes elements and themes of the media
		/// </summary>
		public GraphQLQueryField TagsQueryField()
		{
			return Tags;
		}

		/// <summary>
		/// Other media in the same or connecting franchise
		/// </summary>
		public GraphQLQueryField RelationsQueryField()
		{
			return Relations;
		}

        /// <summary>
        /// The characters in the media.
        /// <list type="bullet">
        /// <listheader><term>Allowed params</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>Role:</term><description>Role of the character.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQLQueryField<CharacterQueryArguments> CharactersQueryField(CharacterQueryArguments arguments = null)
        {
            return Characters.GetGraphFieldAndSetFieldArguments(arguments);
        }

        /// <summary>
        /// The staff who produced the media
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQLQueryField<StaffQueryArguments> StaffQueryField(StaffQueryArguments arguments = null)
		{
			return Staff.GetGraphFieldAndSetFieldArguments(arguments);
		}

        /// <summary>
        /// The companies who produced the media
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>IsMain:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQLQueryField<StudioQueryArguments> StudiosQueryField(StudioQueryArguments arguments = null)
		{
			return Studios.GetGraphFieldAndSetFieldArguments(arguments);
		}

		/// <summary>
		/// If the media is marked as favourite by the current authenticated user
		/// </summary>
		public GraphQLQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// If the media is intended only for 18+ adult audiences
		/// </summary>
		public GraphQLQueryField IsAdultQueryField()
		{
			return IsAdult;
		}

		/// <summary>
		/// The media's next episode airing schedule
		/// </summary>
		public GraphQLQueryField NextAiringEpisodeQueryField()
		{
			return NextAiringEpisode;
		}

        /// <summary>
        /// The media's entire airing schedule
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>NotYetAired:</term><description>Whether the media has airing or not.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQLQueryField<AiringScheduleQueryArguments> AiringScheduleQueryField(AiringScheduleQueryArguments arguments)
		{
			return AiringSchedule.GetGraphFieldAndSetFieldArguments(arguments);
		}

		/// <summary>
		/// External links to another site related to the media
		/// </summary>
		public GraphQLQueryField ExternalLinksQueryField()
		{
			return ExternalLinks;
		}

		/// <summary>
		/// Data and links to legal streaming episodes on external sites
		/// </summary>
		public GraphQLQueryField StreamingEpisodesQueryField()
		{
			return StreamingEpisodes;
		}

		/// <summary>
		/// The ranking of the media in a particular time span and format compared to other media
		/// </summary>
		public GraphQLQueryField RankingsQueryField()
		{
			return Rankings;
		}

		/// <summary>
		/// The authenticated user's media list entry for the media
		/// </summary>
		public GraphQLQueryField MediaListEntryQueryField()
		{
			return MediaListEntry;
		}

        /// <summary>
        /// User reviews of the media
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Limit:</term><description>The review limit.</description></item>
        /// <item><term>Sort:</term><description> The fields to sort by.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQLQueryField<ReviewQueryArguments> ReviewsQueryField(ReviewQueryArguments arguments = null)
		{
			return Reviews.GetGraphFieldAndSetFieldArguments(arguments);
		}

		public GraphQLQueryField StatsQueryField()
		{
			return Stats;
		}

		/// <summary>
		/// The url for the media page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// If the media should have forum thread automatically created for it on airing episode release
		/// </summary>
		public GraphQLQueryField AutoCreateForumThreadQueryField()
		{
			return AutoCreateForumThread;
		}

		/// <summary>
		/// Notes for site moderators
		/// </summary>
		public GraphQLQueryField ModNotesQueryField()
		{
			return ModNotes;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField IdMal { get; set; }
		private GraphQLQueryField Title { get; set; }
		private GraphQLQueryField Type { get; set; }
		private GraphQLQueryField Format { get; set; }
		private GraphQLQueryField Status { get; set; }
		private GraphQLQueryField Description { get; set; }
		private GraphQLQueryField StartDate { get; set; }
		private GraphQLQueryField EndDate { get; set; }
		private GraphQLQueryField Season { get; set; }
		private GraphQLQueryField Episodes { get; set; }
		private GraphQLQueryField Duration { get; set; }
		private GraphQLQueryField Chapters { get; set; }
		private GraphQLQueryField Volumes { get; set; }
		private GraphQLQueryField CountryOfOrigin { get; set; }
		private GraphQLQueryField IsLicensed { get; set; }
		private GraphQLQueryField Source { get; set; }
		private GraphQLQueryField Hashtag { get; set; }
		private GraphQLQueryField Trailer { get; set; }
		private GraphQLQueryField UpdatedAt { get; set; }
		private GraphQLQueryField CoverImage { get; set; }
		private GraphQLQueryField BannerImage { get; set; }
		private GraphQLQueryField Genres { get; set; }
		private GraphQLQueryField Synonyms { get; set; }
		private GraphQLQueryField AverageScore { get; set; }
		private GraphQLQueryField MeanScore { get; set; }
		private GraphQLQueryField Popularity { get; set; }
		private GraphQLQueryField Tags { get; set; }
		private GraphQLQueryField Relations { get; set; }
		private GraphQLQueryField<CharacterQueryArguments> Characters { get; set; }
		private GraphQLQueryField<StaffQueryArguments> Staff { get; set; }
		private GraphQLQueryField<StudioQueryArguments> Studios { get; set; }
		private GraphQLQueryField IsFavourite { get; set; }
		private GraphQLQueryField IsAdult { get; set; }
		private GraphQLQueryField NextAiringEpisode { get; set; }
		private GraphQLQueryField<AiringScheduleQueryArguments> AiringSchedule { get; set; }
		private GraphQLQueryField ExternalLinks { get; set; }
		private GraphQLQueryField StreamingEpisodes { get; set; }
		private GraphQLQueryField Rankings { get; set; }
		private GraphQLQueryField MediaListEntry { get; set; }
		private GraphQLQueryField<ReviewQueryArguments> Reviews { get; set; }
		private GraphQLQueryField Stats { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField AutoCreateForumThread { get; set; }
		private GraphQLQueryField ModNotes { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			IdMal = new GraphQLQueryField("idMal", new FieldRules(false));
			Title = new GraphQLQueryField("title", new FieldRules(false));
			Type = new GraphQLQueryField("type", new FieldRules(false));
			Format = new GraphQLQueryField("format", new FieldRules(false));
			Status = new GraphQLQueryField("status", new FieldRules(false));
			Description = new GraphQLQueryField("description", new FieldRules(false));
			StartDate = new GraphQLQueryField("startDate", new FieldRules(false));
			EndDate = new GraphQLQueryField("endDate", new FieldRules(false));
			Season = new GraphQLQueryField("season", new FieldRules(false));
			Episodes = new GraphQLQueryField("episodes", new FieldRules(false));
			Duration = new GraphQLQueryField("duration", new FieldRules(false));
			Chapters = new GraphQLQueryField("chapters", new FieldRules(false));
			Volumes = new GraphQLQueryField("volumes", new FieldRules(false));
			CountryOfOrigin = new GraphQLQueryField("countryOfOrigin", new FieldRules(false));
			IsLicensed = new GraphQLQueryField("isLicensed", new FieldRules(false));
			Source = new GraphQLQueryField("source", new FieldRules(false));
			Hashtag = new GraphQLQueryField("hashtag", new FieldRules(false));
			Trailer = new GraphQLQueryField("trailer", new FieldRules(false));
			UpdatedAt = new GraphQLQueryField("updatedAt", new FieldRules(false));
			CoverImage = new GraphQLQueryField("coverImage", new FieldRules(false));
			BannerImage = new GraphQLQueryField("bannerImage", new FieldRules(false));
			Genres = new GraphQLQueryField("genres", new FieldRules(false));
			Synonyms = new GraphQLQueryField("synonyms", new FieldRules(false));
			AverageScore = new GraphQLQueryField("averageScore", new FieldRules(false));
			MeanScore = new GraphQLQueryField("meanScore", new FieldRules(false));
			Popularity = new GraphQLQueryField("popularity", new FieldRules(false));
			Tags = new GraphQLQueryField("tags", new FieldRules(false));
			Relations = new GraphQLQueryField("relations", new FieldRules(false));
			Characters = new GraphQLQueryField<CharacterQueryArguments>("characters", new FieldRules(false));
			Staff = new GraphQLQueryField<StaffQueryArguments>("staff", new FieldRules(false));
			Studios = new GraphQLQueryField<StudioQueryArguments>("studios", new FieldRules(false));
			IsFavourite = new GraphQLQueryField("isFavourite", new FieldRules(false));
			IsAdult = new GraphQLQueryField("isAdult", new FieldRules(false));
			NextAiringEpisode = new GraphQLQueryField("nextAiringEpisode", new FieldRules(false));
			AiringSchedule = new GraphQLQueryField<AiringScheduleQueryArguments>("airingSchedule", new FieldRules(false));
			ExternalLinks = new GraphQLQueryField("externalLinks", new FieldRules(false));
			StreamingEpisodes = new GraphQLQueryField("streamingEpisodes", new FieldRules(false));
			Rankings = new GraphQLQueryField("rankings", new FieldRules(false));
			MediaListEntry = new GraphQLQueryField("mediaListEntry", new FieldRules(false));
			Reviews = new GraphQLQueryField<ReviewQueryArguments>("reviews", new FieldRules(false));
			Stats = new GraphQLQueryField("stats", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			AutoCreateForumThread = new GraphQLQueryField("autoCreateForumThread", new FieldRules(false));
			ModNotes = new GraphQLQueryField("modNotes", new FieldRules(false));
		}
	}
}
