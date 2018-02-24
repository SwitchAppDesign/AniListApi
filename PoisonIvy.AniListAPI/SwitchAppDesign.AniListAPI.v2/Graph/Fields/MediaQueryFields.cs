using System;
using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
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
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Title)}) requires at least one media title query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaTitleQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media title query fields {fields.Where(x => x.ParentClassType != typeof(MediaTitleQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

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
		    return StartDate.GetGraphFieldAndSetFieldArguments(new FuzzyDateQueryFields(AniListQueryType.Media).GetAllFields());
        }

		/// <summary>
		/// The last official release date of the media
		/// </summary>
		public GraphQueryField EndDateQueryField()
		{
		    return EndDate.GetGraphFieldAndSetFieldArguments(new FuzzyDateQueryFields(AniListQueryType.Media).GetAllFields());
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
        public GraphQueryField TrailerQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Trailer)}) requires at least one media trailer query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaTrailerQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media trailer query fields {fields.Where(x => x.ParentClassType != typeof(MediaTrailerQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Trailer.GetGraphFieldAndSetFieldArguments(fields);
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
        public GraphQueryField CoverImageQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(CoverImage)}) requires at least one image data query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(ImageDataQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid image data query fields {fields.Where(x => x.ParentClassType != typeof(ImageDataQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return CoverImage.GetGraphFieldAndSetFieldArguments(fields);
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
        public GraphQueryField TagsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Tags)}) requires at least one media tag query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaTagQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media tag query fields {fields.Where(x => x.ParentClassType != typeof(MediaTagQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

            return Tags.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// Other media in the same or connecting franchise
        /// </summary>
        public GraphQueryField RelationsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Relations)}) requires at least one media connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media connection query fields {fields.Where(x => x.ParentClassType != typeof(MediaConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Relations.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The characters in the media. <see cref="string"/>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({nameof(Characters)}) requires at least one character connection query field.");

            if (fields.Any(x => x.ParentClassType != typeof(CharacterConnectionQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid character connection query fields {fields.Where(x => x.ParentClassType != typeof(CharacterConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

            if (arguments != null)
            {
                if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(CharacterConnectionQueryArguments)))
                {
                    throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({Characters.GetType().Name}): {
                        arguments
                            .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(CharacterConnectionQueryArguments))
                            .Select(x => nameof(x))
                            .Aggregate((x, y) => $"{x}, {y}")}.");
                }

                foreach (var argument in arguments)
                    argument.IsValidArgumentType();
            }

            return Characters.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

        /// <summary>
        /// The staff who produced the media
        /// </summary>
        public GraphQueryField StaffQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Staff)}) requires at least one staff connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StaffConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid staff connection query fields {fields.Where(x => x.ParentClassType != typeof(StaffConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(StaffConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({Staff.GetType().Name}): {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(StaffConnectionQueryArguments))
		                    .Select(x => nameof(x))
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return Staff.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

        /// <summary>
        /// The companies who produced the media.
        /// </summary>
        public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields, IList<GraphQueryArgument<object>> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Studios)}) requires at least one studio connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StudioConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid studio connection query fields {fields.Where(x => x.ParentClassType != typeof(StudioConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(StudioConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({Studios.GetType().Name}): {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(StudioConnectionQueryArguments))
		                    .Select(x => x.FieldName)
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return Studios.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

		/// <summary>
		/// If the media is marked as favourite by the current authenticated user.
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// If the media is intended only for 18+ adult audiences.
		/// </summary>
		public GraphQueryField IsAdultQueryField()
		{
			return IsAdult;
		}

        /// <summary>
        /// The media's next episode airing schedule.
        /// </summary>
        public GraphQueryField NextAiringEpisodeQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(NextAiringEpisode)}) requires at least one airing schedule query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(AiringScheduleQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid airing schedule query fields {fields.Where(x => x.ParentClassType != typeof(AiringScheduleQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return NextAiringEpisode.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The media's entire airing schedule.
        /// </summary>
        public GraphQueryField AiringScheduleQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(AiringSchedule)}) requires at least one airing schedule connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(AiringScheduleConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid airing schedule connection query fields {fields.Where(x => x.ParentClassType != typeof(AiringScheduleConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(AiringScheduleConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({AiringSchedule.GetType().Name}): {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(AiringScheduleConnectionQueryArguments))
		                    .Select(x => nameof(x))
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return AiringSchedule.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

        /// <summary>
        /// External links to another site related to the media.
        /// </summary>
        public GraphQueryField ExternalLinksQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(ExternalLinks)}) requires at least one media external link query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaExternalLinkQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media external link query fields {fields.Where(x => x.ParentClassType != typeof(MediaExternalLinkQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return ExternalLinks.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// Data and links to legal streaming episodes on external sites.
        /// </summary>
        public GraphQueryField StreamingEpisodesQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(StreamingEpisodes)}) requires at least one media streaming episode query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaStreamingEpisodeQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media streaming episode query fields {fields.Where(x => x.ParentClassType != typeof(MediaStreamingEpisodeQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return StreamingEpisodes.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The ranking of the media in a particular time span and format compared to other media.
        /// </summary>
        public GraphQueryField RankingsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Rankings)}) requires at least one media rank query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaRankQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media rank query fields {fields.Where(x => x.ParentClassType != typeof(MediaRankQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Rankings.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The authenticated user's media list entry for the media.
        /// </summary>
        public GraphQueryField MediaListEntryQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(MediaListEntry)}) requires at least one media list query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaListQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media list query fields {fields.Where(x => x.ParentClassType != typeof(MediaListQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return MediaListEntry.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// User reviews of the media.
        /// </summary>
        public GraphQueryField ReviewsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({nameof(Reviews)}) requires at least one review connection query field.");

            if (fields.Any(x => x.ParentClassType != typeof(ReviewConnectionQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid review connection query fields {fields.Where(x => x.ParentClassType != typeof(ReviewConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type) x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(ReviewConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({Reviews.GetType().Name}): {
                                arguments
                                .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(ReviewConnectionQueryArguments))
                                .Select(x => nameof(x))
                                .Aggregate((x, y) => $"{x}, {y}")}.");
                }

                foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

            return Reviews.GetGraphFieldAndSetFieldArguments(fields, arguments);
		}

        /// <summary>
        /// Media stats
        /// </summary>
		public GraphQueryField StatsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Stats)}) requires at least one media stats query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaStatsQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media stats query fields {fields.Where(x => x.ParentClassType != typeof(MediaStatsQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Stats.GetGraphFieldAndSetFieldArguments(fields);
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
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			IdMal = new GraphQueryField("idMal", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Title = new GraphQueryField("title", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Type = new GraphQueryField("type", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Format = new GraphQueryField("format", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Status = new GraphQueryField("status", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Description = new GraphQueryField("description", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			StartDate = new GraphQueryField("startDate", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			EndDate = new GraphQueryField("endDate", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Season = new GraphQueryField("season", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Episodes = new GraphQueryField("episodes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Duration = new GraphQueryField("duration", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Chapters = new GraphQueryField("chapters", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Volumes = new GraphQueryField("volumes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			CountryOfOrigin = new GraphQueryField("countryOfOrigin", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			IsLicensed = new GraphQueryField("isLicensed", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Source = new GraphQueryField("source", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Hashtag = new GraphQueryField("hashtag", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Trailer = new GraphQueryField("trailer", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			UpdatedAt = new GraphQueryField("updatedAt", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			CoverImage = new GraphQueryField("coverImage", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			BannerImage = new GraphQueryField("bannerImage", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Genres = new GraphQueryField("genres", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Synonyms = new GraphQueryField("synonyms", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			AverageScore = new GraphQueryField("averageScore", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			MeanScore = new GraphQueryField("meanScore", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Popularity = new GraphQueryField("popularity", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Tags = new GraphQueryField("tags", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Relations = new GraphQueryField("relations", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Characters = new GraphQueryField("characters", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Staff = new GraphQueryField("staff", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Studios = new GraphQueryField("studios", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			IsFavourite = new GraphQueryField("isFavourite", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			IsAdult = new GraphQueryField("isAdult", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			NextAiringEpisode = new GraphQueryField("nextAiringEpisode", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			AiringSchedule = new GraphQueryField("airingSchedule", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			ExternalLinks = new GraphQueryField("externalLinks", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			StreamingEpisodes = new GraphQueryField("streamingEpisodes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Rankings = new GraphQueryField("rankings", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			MediaListEntry = new GraphQueryField("mediaListEntry", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Reviews = new GraphQueryField("reviews", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			Stats = new GraphQueryField("stats", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			SiteUrl = new GraphQueryField("siteUrl", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			AutoCreateForumThread = new GraphQueryField("autoCreateForumThread", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
			ModNotes = new GraphQueryField("modNotes", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> {  AniListQueryType.Media , AniListQueryType.Page  }));
		}
	}
}
