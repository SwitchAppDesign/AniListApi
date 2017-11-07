using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    public class MediaArguments
    {
        private static MediaArguments _instance;
        public static MediaArguments Instance => _instance ?? (_instance = new MediaArguments());

        private MediaArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the media id
        /// </summary>
        public QueryArgument Id { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id
        /// </summary>
        public QueryArgument IdMyAnimeList { get; set; }

        /// <summary>
        /// Filter by the start date of the media
        /// </summary>
        public QueryArgument StartDate { get; set; }

        /// <summary>
        /// Filter by the end date of the media
        /// </summary>
        public QueryArgument EndDate { get; set; }

        /// <summary>
        /// Filter by the season the media was released in
        /// </summary>
        public QueryArgument Season { get; set; }

        /// <summary>
        /// The year of the season (Winter 2017 would also include December 2016 releases). Requires season argument
        /// </summary>
        public QueryArgument SeasonYear { get; set; }

        /// <summary>
        /// Filter by the media's type
        /// </summary>
        public QueryArgument Type { get; set; }

        /// <summary>
        /// Filter by the media's format
        /// </summary>
        public QueryArgument Format { get; set; }

        /// <summary>
        /// Filter by the media's current release status
        /// </summary>
        public QueryArgument Status { get; set; }

        /// <summary>
        /// Filter by amount of episodes the media has
        /// </summary>
        public QueryArgument Episodes { get; set; }

        /// <summary>
        /// Filter by the media's episode length
        /// </summary>
        public QueryArgument Duration { get; set; }

        /// <summary>
        /// Filter by the media's chapter count
        /// </summary>
        public QueryArgument Chapters { get; set; }

        /// <summary>
        /// Filter by the media's volume count
        /// </summary>
        public QueryArgument Volumes { get; set; }

        /// <summary>
        /// Filter by if the media's intended for 18+ adult audiences
        /// </summary>
        public QueryArgument IsAdult { get; set; }

        /// <summary>
        /// Filter by the media's genres
        /// </summary>
        public QueryArgument Genre { get; set; }

        /// <summary>
        /// Filter by the media's tags
        /// </summary>
        public QueryArgument Tag { get; set; }

        /// <summary>
        /// Filter by the media's tags with in a tag category
        /// </summary>
        public QueryArgument TagCategory { get; set; }

        /// <summary>
        /// Filter by the media on the authenticated user's lists
        /// </summary>
        public QueryArgument OnList { get; set; }

        /// <summary>
        /// Filter by the media's average score
        /// </summary>
        public QueryArgument AverageScore { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list
        /// </summary>
        public QueryArgument Popularity { get; set; }

        /// <summary>
        /// Filter by search query
        /// </summary>
        public QueryArgument Search { get; set; }

        /// <summary>
        /// Filter by the media id
        /// </summary>
        public QueryArgument IdNot { get; set; }

        /// <summary>
        /// Filter by the media id
        /// </summary>
        public QueryArgument IdIn { get; set; }

        /// <summary>
        /// Filter by the media id
        /// </summary>
        public QueryArgument IdNotIn { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id
        /// </summary>
        public QueryArgument IdMyAnimeListNot { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id
        /// </summary>
        public QueryArgument IdMyAnimeListIn { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id
        /// </summary>
        public QueryArgument IdMyAnimeListNotIn { get; set; }

        /// <summary>
        /// Filter by the start date of the media
        /// </summary>
        public QueryArgument StartDateGreater { get; set; }

        /// <summary>
        /// Filter by the start date of the media
        /// </summary>
        public QueryArgument StartDateLesser { get; set; }

        /// <summary>
        /// Filter by the start date of the media
        /// </summary>
        public QueryArgument StartDateLike { get; set; }

        /// <summary>
        /// Filter by the end date of the media
        /// </summary>
        public QueryArgument EndDateGreater { get; set; }

        /// <summary>
        /// Filter by the end date of the media
        /// </summary>
        public QueryArgument EndDateLesser { get; set; }

        /// <summary>
        /// Filter by the end date of the media
        /// </summary>
        public QueryArgument EndDateLike { get; set; }

        /// <summary>
        /// Filter by amount of episodes the media has
        /// </summary>
        public QueryArgument EpisodesGreater { get; set; }

        /// <summary>
        /// Filter by amount of episodes the media has
        /// </summary>
        public QueryArgument EpisodesLesser { get; set; }

        /// <summary>
        /// Filter by the media's episode length
        /// </summary>
        public QueryArgument DurationGreater { get; set; }

        /// <summary>
        /// Filter by the media's episode length
        /// </summary>
        public QueryArgument DurationLesser { get; set; }

        /// <summary>
        /// Filter by the media's chapter count
        /// </summary>
        public QueryArgument ChaptersGreater { get; set; }

        /// <summary>
        /// Filter by the media's chapter count
        /// </summary>
        public QueryArgument ChaptersLesser { get; set; }

        /// <summary>
        /// Filter by the media's volume count
        /// </summary>
        public QueryArgument VolumesGreater { get; set; }

        /// <summary>
        /// Filter by the media's volume count
        /// </summary>
        public QueryArgument VolumesLesser { get; set; }

        /// <summary>
        /// Filter by the media's genres
        /// </summary>
        public QueryArgument GenreIn { get; set; }

        /// <summary>
        /// Filter by the media's genres
        /// </summary>
        public QueryArgument GenreNotIn { get; set; }

        /// <summary>
        /// Filter by the media's tags
        /// </summary>
        public QueryArgument TagIn { get; set; }

        /// <summary>
        /// Filter by the media's tags
        /// </summary>
        public QueryArgument TagNotIn { get; set; }

        /// <summary>
        /// Filter by the media's tags with in a tag category
        /// </summary>
        public QueryArgument TagCategoryIn { get; set; }

        /// <summary>
        /// Filter by the media's tags with in a tag category
        /// </summary>
        public QueryArgument TagCategoryNotIn { get; set; }

        /// <summary>
        /// Filter by the media's average score
        /// </summary>
        public QueryArgument AverageScoreNot { get; set; }

        /// <summary>
        /// Filter by the media's average score
        /// </summary>
        public QueryArgument AverageScoreGreater { get; set; }

        /// <summary>
        /// Filter by the media's average score
        /// </summary>
        public QueryArgument AverageScoreLesser { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list
        /// </summary>
        public QueryArgument PopularityNot { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list
        /// </summary>
        public QueryArgument PopularityGreater { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list
        /// </summary>
        public QueryArgument PopularityLesser { get; set; }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public QueryArgument Sort { get; set; }


        private void InitializeProperties()
        {
            Id = new QueryArgument("id");
            IdMyAnimeList = new QueryArgument("idMal");
            StartDate = new QueryArgument("startDate");
            EndDate = new QueryArgument("endDate");
            Season = new QueryArgument("season");
            SeasonYear = new QueryArgument("seasonYear");
            Type = new QueryArgument("type");
            Format = new QueryArgument("format");
            Status = new QueryArgument("status");
            Episodes = new QueryArgument("episodes");
            Duration = new QueryArgument("duration");
            Chapters = new QueryArgument("chapters");
            Volumes = new QueryArgument("volumes");
            IsAdult = new QueryArgument("isAdult");
            Genre = new QueryArgument("genre");
            Tag = new QueryArgument("tag");
            TagCategory = new QueryArgument("tagCategory");
            OnList = new QueryArgument("onList");
            AverageScore = new QueryArgument("averageScore");
            Popularity = new QueryArgument("popularity");
            Search = new QueryArgument("search");
            IdNot = new QueryArgument("id_not");
            IdIn = new QueryArgument("id_in");
            IdNotIn = new QueryArgument("id_not_in");
            IdMyAnimeListNot = new QueryArgument("idMal_not");
            IdMyAnimeListIn = new QueryArgument("idMal_in");
            IdMyAnimeListNotIn = new QueryArgument("idMal_not_in");
            StartDateGreater = new QueryArgument("startDate_greater");
            StartDateLesser = new QueryArgument("startDate_lesser");
            StartDateLike = new QueryArgument("startDate_like");
            EndDateGreater = new QueryArgument("endDate_greater");
            EndDateLesser = new QueryArgument("endDate_lesser");
            EndDateLike = new QueryArgument("endDate_like");
            EpisodesGreater = new QueryArgument("episodes_greater");
            EpisodesLesser = new QueryArgument("episodes_lesser");
            DurationGreater = new QueryArgument("duration_greater");
            DurationLesser = new QueryArgument("duration_lesser");
            ChaptersGreater = new QueryArgument("chapters_greater");
            ChaptersLesser = new QueryArgument("chapters_lesser");
            VolumesGreater = new QueryArgument("volumes_greater");
            VolumesLesser = new QueryArgument("volumes_lesser");
            GenreIn = new QueryArgument("genre_in");
            GenreNotIn = new QueryArgument("genre_not_in");
            TagIn = new QueryArgument("tag_in");
            TagNotIn = new QueryArgument("tag_not_in");
            TagCategoryIn = new QueryArgument("tagCategory_in");
            TagCategoryNotIn = new QueryArgument("tagCategory_not_in");
            AverageScoreNot = new QueryArgument("averageScore_not");
            AverageScoreGreater = new QueryArgument("averageScore_greater");
            AverageScoreLesser = new QueryArgument("averageScore_lesser");
            PopularityNot = new QueryArgument("popularity_not");
            PopularityGreater = new QueryArgument("popularity_greater");
            PopularityLesser = new QueryArgument("popularity_lesser");
            Sort = new QueryArgument("sort");
        }
    }
}
