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
        private readonly List<AniListQueryType> _allowedQueryTypes;
        private readonly AniListQueryType _queryType;

		internal MediaQueryFields(AniListQueryType queryType)
		{
		    _queryType = queryType;

            _allowedQueryTypes = new List<AniListQueryType>
		    {
		        AniListQueryType.Media,
                AniListQueryType.Page
		    };
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The mal id of the media
		/// </summary>
		public GraphQueryField IdMalQueryField()
		{
			return new GraphQueryField("idMal", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// The official titles of the media in various languages
        /// </summary>
        public GraphQueryField TitleQueryField(IList<GraphQueryField> fields)
        {
            var field = new GraphQueryField("title", GetType(), _queryType, InitilizeDefaultFieldRules());

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// The type of the media; anime or manga
		/// </summary>
		public GraphQueryField TypeQueryField()
		{
            return new GraphQueryField("type", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The format the media was released in
		/// </summary>
		public GraphQueryField FormatQueryField()
		{
            return new GraphQueryField("format", GetType(), _queryType, InitilizeDefaultFieldRules());
            
        }

		/// <summary>
		/// The current releasing status of the media
		/// </summary>
		public GraphQueryField StatusQueryField()
		{
			return new GraphQueryField("status", GetType(), _queryType, InitilizeDefaultFieldRules());
            
        }

		/// <summary>
		/// Short description of the media's story and characters
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return new GraphQueryField("description", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The first official release date of the media
		/// </summary>
		public GraphQueryField StartDateQueryField()
		{
		    return new GraphQueryField("startDate", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(new FuzzyDateQueryFields(AniListQueryType.Media).GetAllFields());
        }

		/// <summary>
		/// The last official release date of the media
		/// </summary>
		public GraphQueryField EndDateQueryField()
		{
		    return new GraphQueryField("endDate", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(new FuzzyDateQueryFields(AniListQueryType.Media).GetAllFields());
        }

		/// <summary>
		/// The season the media was initially released in
		/// </summary>
		public GraphQueryField SeasonQueryField()
		{
            return new GraphQueryField("season", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of episodes the anime has when complete
		/// </summary>
		public GraphQueryField EpisodesQueryField()
		{
			return new GraphQueryField("episodes", GetType(), _queryType, InitilizeDefaultFieldRules());
		}

		/// <summary>
		/// The general length of each anime episode in minutes
		/// </summary>
		public GraphQueryField DurationQueryField()
		{
            return new GraphQueryField("duration", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of chapters the manga has when complete
		/// </summary>
		public GraphQueryField ChaptersQueryField()
		{
            return new GraphQueryField("chapters", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of volumes the manga has when complete
		/// </summary>
		public GraphQueryField VolumesQueryField()
		{
            return new GraphQueryField("volumes", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// Where the media was created. (ISO 3166-1 alpha-2)
		/// </summary>
		public GraphQueryField CountryOfOriginQueryField()
		{
            return new GraphQueryField("countryOfOrigin", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// If the media is officially licensed or a self-published doujin release
		/// </summary>
		public GraphQueryField IsLicensedQueryField()
		{
            return new GraphQueryField("isLicensed", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// Source type the media was adapted from.
		/// </summary>
		public GraphQueryField SourceQueryField()
		{
            return new GraphQueryField("source", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// Official Twitter hashtags for the media
		/// </summary>
		public GraphQueryField HashtagQueryField()
		{
            return new GraphQueryField("hashtag", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// Media trailer or advertisement
        /// </summary>
        public GraphQueryField TrailerQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("trailer", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// When the media's data was last updated
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
            return new GraphQueryField("updatedAt", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// The cover images of the media
        /// </summary>
        public GraphQueryField CoverImageQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("coverImage", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// The banner image of the media
		/// </summary>
		public GraphQueryField BannerImageQueryField()
		{
            return new GraphQueryField("bannerImage", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The genres of the media
		/// </summary>
		public GraphQueryField GenresQueryField()
		{
            return new GraphQueryField("genres", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// Alternative titles of the media
		/// </summary>
		public GraphQueryField SynonymsQueryField()
		{
            return new GraphQueryField("synonyms", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// A weighted average score of all the user's scores of the media
		/// </summary>
		public GraphQueryField AverageScoreQueryField()
		{
            return new GraphQueryField("averageScore", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// Mean score of all the user's scores of the media
		/// </summary>
		public GraphQueryField MeanScoreQueryField()
		{
            return new GraphQueryField("meanScore", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The number of users with the media on their list
		/// </summary>
		public GraphQueryField PopularityQueryField()
		{
            return new GraphQueryField("popularity", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// List of tags that describes elements and themes of the media
        /// </summary>
        public GraphQueryField TagsQueryField(IList<GraphQueryField> fields)
        {
            var field = new GraphQueryField("tags", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// Other media in the same or connecting franchise
        /// </summary>
        public GraphQueryField RelationsQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("relations", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// The characters in the media. <see cref="string"/>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
        {
            var field = new GraphQueryField("characters", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

        /// <summary>
        /// The staff who produced the media
        /// </summary>
        public GraphQueryField StaffQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
            var field = new GraphQueryField("staff", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

        /// <summary>
        /// The companies who produced the media.
        /// </summary>
        public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
            var field = new GraphQueryField("studios", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

		/// <summary>
		/// If the media is marked as favourite by the current authenticated user.
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
		    return new GraphQueryField("isFavourite", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// If the media is intended only for 18+ adult audiences.
		/// </summary>
		public GraphQueryField IsAdultQueryField()
		{
		    return new GraphQueryField("isAdult", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        /// <summary>
        /// The media's next episode airing schedule.
        /// </summary>
        public GraphQueryField NextAiringEpisodeQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("nextAiringEpisode", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// The media's entire airing schedule.
        /// </summary>
        public GraphQueryField AiringScheduleQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
            var field = new GraphQueryField("airingSchedule", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

        /// <summary>
        /// External links to another site related to the media.
        /// </summary>
        public GraphQueryField ExternalLinksQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("externalLinks", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// Data and links to legal streaming episodes on external sites.
        /// </summary>
        public GraphQueryField StreamingEpisodesQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("streamingEpisodes", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;

        }

        /// <summary>
        /// The ranking of the media in a particular time span and format compared to other media.
        /// </summary>
        public GraphQueryField RankingsQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("rankings", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// The authenticated user's media list entry for the media.
        /// </summary>
        public GraphQueryField MediaListEntryQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("mediaListEntry", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// User reviews of the media.
        /// </summary>
        public GraphQueryField ReviewsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
            var field = new GraphQueryField("reviews", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

        /// <summary>
        /// Media stats
        /// </summary>
		public GraphQueryField StatsQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("stats", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// The url for the media page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the media should have forum thread automatically created for it on airing episode release
		/// </summary>
		public GraphQueryField AutoCreateForumThreadQueryField()
		{
			return new GraphQueryField("autoCreateForumThread", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// Notes for site moderators
		/// </summary>
		public GraphQueryField ModNotesQueryField()
		{
			return new GraphQueryField("modNotes", GetType(), _queryType, InitilizeDefaultFieldRules());
		}

        private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
        {
            return new FieldRules(authenticationRequired, _allowedQueryTypes);
        }
	}
}
