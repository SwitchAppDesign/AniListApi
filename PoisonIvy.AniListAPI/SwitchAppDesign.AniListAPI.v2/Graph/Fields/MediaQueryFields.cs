using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Media
    {
        public Media()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the media
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The mal id of the media
        /// </summary>
        public GraphQLQueryField IdMalQueryField { get; private set; }

        /// <summary>
        /// The official titles of the media in various languages
        /// </summary>
        public GraphQLQueryField TitleQueryField { get; private set; }

        /// <summary>
        /// The type of the media; anime or manga
        /// </summary>
        public GraphQLQueryField TypeQueryField { get; private set; }

        /// <summary>
        /// The format the media was released in
        /// </summary>
        public GraphQLQueryField FormatQueryField { get; private set; }

        /// <summary>
        /// The current releasing status of the media
        /// </summary>
        public GraphQLQueryField StatusQueryField { get; private set; }

        /// <summary>
        /// Short description of the media's story and characters
        /// </summary>
        public GraphQLQueryField DescriptionQueryField { get; private set; }

        /// <summary>
        /// The first official release date of the media
        /// </summary>
        public GraphQLQueryField StartDateQueryField { get; private set; }

        /// <summary>
        /// The last official release date of the media
        /// </summary>
        public GraphQLQueryField EndDateQueryField { get; private set; }

        /// <summary>
        /// The season the media was initially released in
        /// </summary>
        public GraphQLQueryField SeasonQueryField { get; private set; }

        /// <summary>
        /// The amount of episodes the anime has when complete
        /// </summary>
        public GraphQLQueryField EpisodesQueryField { get; private set; }

        /// <summary>
        /// The general length of each anime episode in minutes
        /// </summary>
        public GraphQLQueryField DurationQueryField { get; private set; }

        /// <summary>
        /// The amount of chapters the manga has when complete
        /// </summary>
        public GraphQLQueryField ChaptersQueryField { get; private set; }

        /// <summary>
        /// The amount of volumes the manga has when complete
        /// </summary>
        public GraphQLQueryField VolumesQueryField { get; private set; }

        /// <summary>
        /// Where the media was created. (ISO 3166-1 alpha-2)
        /// </summary>
        public GraphQLQueryField CountryOfOriginQueryField { get; private set; }

        /// <summary>
        /// If the media is officially licensed or a self-published doujin release
        /// </summary>
        public GraphQLQueryField IsLicensedQueryField { get; private set; }

        /// <summary>
        /// Source type the media was adapted from.
        /// </summary>
        public GraphQLQueryField SourceQueryField { get; private set; }

        /// <summary>
        /// Official Twitter hashtags for the media
        /// </summary>
        public GraphQLQueryField HashtagQueryField { get; private set; }

        /// <summary>
        /// Media trailer or advertisement
        /// </summary>
        public GraphQLQueryField TrailerQueryField { get; private set; }

        /// <summary>
        /// When the media's data was last updated
        /// </summary>
        public GraphQLQueryField UpdatedAtQueryField { get; private set; }

        /// <summary>
        /// The cover images of the media
        /// </summary>
        public GraphQLQueryField CoverImageQueryField { get; private set; }

        /// <summary>
        /// The banner image of the media
        /// </summary>
        public GraphQLQueryField BannerImageQueryField { get; private set; }

        /// <summary>
        /// The genres of the media
        /// </summary>
        public GraphQLQueryField GenresQueryField { get; private set; }

        /// <summary>
        /// Alternative titles of the media
        /// </summary>
        public GraphQLQueryField SynonymsQueryField { get; private set; }

        /// <summary>
        /// A weighted average score of all the user's scores of the media
        /// </summary>
        public GraphQLQueryField AverageScoreQueryField { get; private set; }

        /// <summary>
        /// Mean score of all the user's scores of the media
        /// </summary>
        public GraphQLQueryField MeanScoreQueryField { get; private set; }

        /// <summary>
        /// The number of users with the media on their list
        /// </summary>
        public GraphQLQueryField PopularityQueryField { get; private set; }

        /// <summary>
        /// List of tags that describes elements and themes of the media
        /// </summary>
        public GraphQLQueryField TagsQueryField { get; private set; }

        /// <summary>
        /// Other media in the same or connecting franchise
        /// </summary>
        public GraphQLQueryField RelationsQueryField { get; private set; }

        /// <summary>
        /// The characters in the media
        /// </summary>
        public GraphQLQueryField CharactersQueryField { get; private set; }

        /// <summary>
        /// The staff who produced the media
        /// </summary>
        public GraphQLQueryField StaffQueryField { get; private set; }

        /// <summary>
        /// The companies who produced the media
        /// </summary>
        public GraphQLQueryField StudiosQueryField { get; private set; }

        /// <summary>
        /// If the media is marked as favourite by the current authenticated user
        /// </summary>
        public GraphQLQueryField IsFavouriteQueryField { get; private set; }

        /// <summary>
        /// If the media is intended only for 18+ adult audiences
        /// </summary>
        public GraphQLQueryField IsAdultQueryField { get; private set; }

        /// <summary>
        /// The media's next episode airing schedule
        /// </summary>
        public GraphQLQueryField NextAiringEpisodeQueryField { get; private set; }

        /// <summary>
        /// The media's entire airing schedule
        /// </summary>
        public GraphQLQueryField AiringScheduleQueryField { get; private set; }

        /// <summary>
        /// External links to another site related to the media
        /// </summary>
        public GraphQLQueryField ExternalLinksQueryField { get; private set; }

        /// <summary>
        /// Data and links to legal streaming episodes on external sites
        /// </summary>
        public GraphQLQueryField StreamingEpisodesQueryField { get; private set; }

        /// <summary>
        /// The ranking of the media in a particular time span and format compared to other media
        /// </summary>
        public GraphQLQueryField RankingsQueryField { get; private set; }

        /// <summary>
        /// The authenticated user's media list entry for the media
        /// </summary>
        public GraphQLQueryField MediaListEntryQueryField { get; private set; }

        /// <summary>
        /// User reviews of the media
        /// </summary>
        public GraphQLQueryField ReviewsQueryField { get; private set; }

        public GraphQLQueryField StatsQueryField { get; private set; }

        /// <summary>
        /// The url for the media page on the AniList website
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// If the media should have forum thread automatically created for it on airing episode release
        /// </summary>
        public GraphQLQueryField AutoCreateForumThreadQueryField { get; private set; }

        /// <summary>
        /// Notes for site moderators
        /// </summary>
        public GraphQLQueryField ModNotesQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            IdMalQueryField = new GraphQLQueryField("idMal", new FieldRules(false));
            TitleQueryField = new GraphQLQueryField("title", new FieldRules(false));
            TypeQueryField = new GraphQLQueryField("type", new FieldRules(false));
            FormatQueryField = new GraphQLQueryField("format", new FieldRules(false));
            StatusQueryField = new GraphQLQueryField("status", new FieldRules(false));
            DescriptionQueryField = new GraphQLQueryField("description", new FieldRules(false));
            StartDateQueryField = new GraphQLQueryField("startDate", new FieldRules(false));
            EndDateQueryField = new GraphQLQueryField("endDate", new FieldRules(false));
            SeasonQueryField = new GraphQLQueryField("season", new FieldRules(false));
            EpisodesQueryField = new GraphQLQueryField("episodes", new FieldRules(false));
            DurationQueryField = new GraphQLQueryField("duration", new FieldRules(false));
            ChaptersQueryField = new GraphQLQueryField("chapters", new FieldRules(false));
            VolumesQueryField = new GraphQLQueryField("volumes", new FieldRules(false));
            CountryOfOriginQueryField = new GraphQLQueryField("countryOfOrigin", new FieldRules(false));
            IsLicensedQueryField = new GraphQLQueryField("isLicensed", new FieldRules(false));
            SourceQueryField = new GraphQLQueryField("source", new FieldRules(false));
            HashtagQueryField = new GraphQLQueryField("hashtag", new FieldRules(false));
            TrailerQueryField = new GraphQLQueryField("trailer", new FieldRules(false));
            UpdatedAtQueryField = new GraphQLQueryField("updatedAt", new FieldRules(false));
            CoverImageQueryField = new GraphQLQueryField("coverImage", new FieldRules(false));
            BannerImageQueryField = new GraphQLQueryField("bannerImage", new FieldRules(false));
            GenresQueryField = new GraphQLQueryField("genres", new FieldRules(false));
            SynonymsQueryField = new GraphQLQueryField("synonyms", new FieldRules(false));
            AverageScoreQueryField = new GraphQLQueryField("averageScore", new FieldRules(false));
            MeanScoreQueryField = new GraphQLQueryField("meanScore", new FieldRules(false));
            PopularityQueryField = new GraphQLQueryField("popularity", new FieldRules(false));
            TagsQueryField = new GraphQLQueryField("tags", new FieldRules(false));
            RelationsQueryField = new GraphQLQueryField("relations", new FieldRules(false));
            CharactersQueryField = new GraphQLQueryField("characters", new FieldRules(false));
            StaffQueryField = new GraphQLQueryField("staff", new FieldRules(false));
            StudiosQueryField = new GraphQLQueryField("studios", new FieldRules(false));
            IsFavouriteQueryField = new GraphQLQueryField("isFavourite", new FieldRules(false));
            IsAdultQueryField = new GraphQLQueryField("isAdult", new FieldRules(false));
            NextAiringEpisodeQueryField = new GraphQLQueryField("nextAiringEpisode", new FieldRules(false));
            AiringScheduleQueryField = new GraphQLQueryField("airingSchedule", new FieldRules(false));
            ExternalLinksQueryField = new GraphQLQueryField("externalLinks", new FieldRules(false));
            StreamingEpisodesQueryField = new GraphQLQueryField("streamingEpisodes", new FieldRules(false));
            RankingsQueryField = new GraphQLQueryField("rankings", new FieldRules(false));
            MediaListEntryQueryField = new GraphQLQueryField("mediaListEntry", new FieldRules(false));
            ReviewsQueryField = new GraphQLQueryField("reviews", new FieldRules(false));
            StatsQueryField = new GraphQLQueryField("stats", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            AutoCreateForumThreadQueryField = new GraphQLQueryField("autoCreateForumThread", new FieldRules(false));
            ModNotesQueryField = new GraphQLQueryField("modNotes", new FieldRules(false));
        }
    }
}
