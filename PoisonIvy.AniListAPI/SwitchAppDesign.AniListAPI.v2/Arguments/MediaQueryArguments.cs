using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    public class MediaQueryArguments
    {
        private static MediaQueryArguments _instance;
        public static MediaQueryArguments Instance => _instance ?? (_instance = new MediaQueryArguments());

        private MediaQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the media id.
        /// </summary>
        public GraphQLQueryArgument<int> GetIdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id.
        /// </summary>
        public GraphQLQueryArgument<int> GetIdMyAnimeListArgument(int value)
        {
            return IdMyAnimeList.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> IdMyAnimeList { get; set; }

        /// <summary>
        /// Filter by the start date of the media.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> StartDateArgument(FuzzyDate value)
        {
            return StartDate.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }

        private GraphQLQueryArgument<FuzzyDateInt> StartDate { get; set; }

        /// <summary>
        /// Filter by the end date of the media.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> EndDateArgument(FuzzyDate value)
        {
            return EndDate.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }

        private GraphQLQueryArgument<FuzzyDateInt> EndDate { get; set; }

        /// <summary>
        /// Filter by the season the media was released in.
        /// </summary>
        public GraphQLQueryArgument<MediaSeason> SeasonArgument(MediaSeason value)
        {
            return Season.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<MediaSeason> Season { get; set; }

        /// <summary>
        /// The year of the season (Winter 2017 would also include December 2016 releases). Requires season argument.
        /// </summary>
        public GraphQLQueryArgument<int> SeasonYearArgument(int value)
        {
            return SeasonYear.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> SeasonYear { get; set; }

        /// <summary>
        /// Filter by the media's type.
        /// </summary>
        public GraphQLQueryArgument<MediaType> TypeArgument(MediaType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<MediaType> Type { get; set; }

        /// <summary>
        /// Filter by the media's format.
        /// </summary>
        public GraphQLQueryArgument<MediaFormat> FormatArgument(MediaFormat value)
        {
            return Format.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<MediaFormat> Format { get; set; }

        /// <summary>
        /// Filter by the media's current release status.
        /// </summary>
        public GraphQLQueryArgument<MediaStatus> FormatArgument(MediaStatus value)
        {
            return Status.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<MediaStatus> Status { get; set; }

        /// <summary>
        /// Filter by amount of episodes the media has.
        /// </summary>
        public GraphQLQueryArgument<int> EpisodesArgument(int value)
        {
            return Episodes.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Episodes { get; set; }

        /// <summary>
        /// Filter by the media's episode length.
        /// </summary>
        public GraphQLQueryArgument<int> DurationArgument(int value)
        {
            return Duration.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Duration { get; set; }

        /// <summary>
        /// Filter by the media's chapter count.
        /// </summary>
        public GraphQLQueryArgument<int> ChaptersArgument(int value)
        {
            return Chapters.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Chapters { get; set; }

        /// <summary>
        /// Filter by the media's volume count.
        /// </summary>
        public GraphQLQueryArgument<int> VolumesArgument(int value)
        {
            return Volumes.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Volumes { get; set; }

        /// <summary>
        /// Filter by if the media's intended for 18+ adult audiences.
        /// </summary>
        public GraphQLQueryArgument<bool> IsAdultArgument(bool value)
        {
            return IsAdult.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<bool> IsAdult { get; set; }

        /// <summary>
        /// Filter by the media's genres.
        /// </summary>
        public GraphQLQueryArgument<string> GenreArgument(Genres value)
        {
            return Genre.GetQueryArgumentAndSetValue(value.GetDescription());
        }

        private GraphQLQueryArgument<string> Genre { get; set; }

        /// <summary>
        /// Filter by the media's tags.
        /// </summary>
        public GraphQLQueryArgument<string> TagArgument(string value)
        {
            return Tag.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<string> Tag { get; set; }

        /// <summary>
        /// Filter by the media's tags with in a tag category.
        /// </summary>
        public GraphQLQueryArgument<string> TagCategoryArgument(string value)
        {
            return TagCategory.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<string> TagCategory { get; set; }

        /// <summary>
        /// Filter by the media on the authenticated user's lists.
        /// </summary>
        public GraphQLQueryArgument<bool> OnListArgument(bool value)
        {
            return OnList.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<bool> OnList { get; set; }

        /// <summary>
        /// Filter by the media's average score
        /// </summary>
        public GraphQLQueryArgument<int> AverageScoreArgument(int value)
        {
            return AverageScore.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> AverageScore { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list
        /// </summary>
        public GraphQLQueryArgument<int> PopularityArgument(int value)
        {
            return Popularity.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Popularity { get; set; }

        /// <summary>
        /// Filter by search query
        /// </summary>
        public GraphQLQueryArgument<string> SearchArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<string> Search { get; set; }

        /// <summary>
        /// Filter by the media id where media id is not equal to value.
        /// </summary>
        public GraphQLQueryArgument<int> IdIsNotArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> IdNot { get; set; }

        /// <summary>
        /// Filter by the media id where media is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdIsInArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }

        /// <summary>
        /// Filter by the media id where media is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdIsNotInArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id where MyAnimeList id is not equal to value.
        /// </summary>
        public GraphQLQueryArgument<int> IdMyAnimeListIsNotArgument(int value)
        {
            return IdMyAnimeListNot.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> IdMyAnimeListNot { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id where MyAnimeList is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdMyAnimeListIsInArgument(IEnumerable<int> value)
        {
            return IdMyAnimeListIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<int>> IdMyAnimeListIn { get; set; }

        /// <summary>
        /// Filter by the media id's MyAnimeList id where MyAnimeList is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdMyAnimeListIsNotInArgument(IEnumerable<int> value)
        {
            return IdMyAnimeListNotIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<int>> IdMyAnimeListNotIn { get; set; }

        /// <summary>
        /// Filter by the start date of the media where start date is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> StartDateGreaterThanArgument(FuzzyDate value)
        {
            return StartDateGreater.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }

        private GraphQLQueryArgument<FuzzyDateInt> StartDateGreater { get; set; }

        /// <summary>
        /// Filter by the start date of the media where start date is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> StartDateLesserThanArgument(FuzzyDate value)
        {
            return StartDateLesser.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }

        private GraphQLQueryArgument<FuzzyDateInt> StartDateLesser { get; set; }

        /// <summary>
        /// Filter by the start date of the media where start date is like the given fuzzy date in string form as a wildcard search 
        /// e.g, new FuzzyDate(2017,10,null) will be "201710%".
        /// </summary>
        public GraphQLQueryArgument<string> StartDateLikeThanArgument(FuzzyDate value)
        {
            return StartDateLike.GetQueryArgumentAndSetValue(value.GetFuzzyDateWildcardString());
        }

        private GraphQLQueryArgument<string> StartDateLike { get; set; }

        /// <summary>
        /// Filter by the end date of the media where end date is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> EndDateGreaterThanArgument(FuzzyDate value)
        {
            return EndDateGreater.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }

        private GraphQLQueryArgument<FuzzyDateInt> EndDateGreater { get; set; }

        /// <summary>
        /// Filter by the end date of the media where end date is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> EndDateLesserThanArgument(FuzzyDate value)
        {
            return EndDateLesser.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }

        private GraphQLQueryArgument<FuzzyDateInt> EndDateLesser { get; set; }

        /// <summary>
        /// Filter by the end date of the media where end date is like the given fuzzy date in string form as a wildcard search 
        /// e.g, new FuzzyDate(2017,10,null) will be "201710%".
        /// </summary>
        public GraphQLQueryArgument<string> EndDateLikeArgument(FuzzyDate value)
        {
            return EndDateLike.GetQueryArgumentAndSetValue(value.GetFuzzyDateWildcardString());
        }

        private GraphQLQueryArgument<string> EndDateLike { get; set; }

        /// <summary>
        /// Filter by amount of episodes the media has where total episodes is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> EpisodesGreaterThanArgument(int value)
        {
            return EpisodesGreater.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> EpisodesGreater { get; set; }

        /// <summary>
        /// Filter by amount of episodes the media has where total episodes is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> EpisodesLesserThanArgument(int value)
        {
            return EpisodesLesser.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> EpisodesLesser { get; set; }

        /// <summary>
        /// Filter by the media's episode length where total duration is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> DurationGreaterThanArgument(int value)
        {
            return DurationGreater.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> DurationGreater { get; set; }

        /// <summary>
        /// Filter by the media's episode length where total duration is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> DurationLesserThanArgument(int value)
        {
            return DurationLesser.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> DurationLesser { get; set; }

        /// <summary>
        /// Filter by the media's chapter count where total chapters is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> ChaptersGreaterThanArgument(int value)
        {
            return ChaptersGreater.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> ChaptersGreater { get; set; }

        /// <summary>
        /// Filter by the media's chapter count where total chapters is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> ChaptersLesserThanArgument(int value)
        {
            return ChaptersLesser.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> ChaptersLesser { get; set; }

        /// <summary>
        /// Filter by the media's volume count where total volumes is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> VolumesGreaterThanArgument(int value)
        {
            return VolumesGreater.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> VolumesGreater { get; set; }

        /// <summary>
        /// Filter by the media's volume count where total volumes is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> VolumesLesserThanArgument(int value)
        {
            return VolumesLesser.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> VolumesLesser { get; set; }

        /// <summary>
        /// Filter by the media's genres where genre is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> GenreInArgument(IEnumerable<string> value)
        {
            return GenreIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> GenreIn { get; set; }

        /// <summary>
        /// Filter by the media's genres where genre is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> GenreNotInArgument(IEnumerable<string> value)
        {
            return GenreNotIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> GenreNotIn { get; set; }

        /// <summary>
        /// Filter by the media's tags where tags is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> TagInArgument(IEnumerable<string> value)
        {
            return TagIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> TagIn { get; set; }

        /// <summary>
        /// Filter by the media's tags where tags is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> TagNotInArgument(IEnumerable<string> value)
        {
            return TagNotIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> TagNotIn { get; set; }

        /// <summary>
        /// Filter by the media's tags with in a tag category where tag category is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> TagCategoryInArgument(IEnumerable<string> value)
        {
            return TagCategoryIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> TagCategoryIn { get; set; }

        /// <summary>
        /// Filter by the media's tags with in a tag category where tag category is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> TagCategoryNotInArgument(IEnumerable<string> value)
        {
            return TagCategoryNotIn.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> TagCategoryNotIn { get; set; }

        /// <summary>
        /// Filter by the media's average score is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> AverageScoreNotArgument(int value)
        {
            return AverageScoreNot.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> AverageScoreNot { get; set; }

        /// <summary>
        /// Filter by the media's average score where average score is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> AverageScoreGreaterThanArgument(int value)
        {
            return AverageScoreGreater.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> AverageScoreGreater { get; set; }

        /// <summary>
        /// Filter by the media's average score where average score is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> AverageScoreLesserThanArgument(int value)
        {
            return AverageScoreLesser.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> AverageScoreLesser { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list where popularity is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> PopularityNotQueryArgument(int value)
        {
            return PopularityNot.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> PopularityNot { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list where popularity is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> PopularityGreaterThanArgument(int value)
        {
            return PopularityGreater.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> PopularityGreater { get; set; }

        /// <summary>
        /// Filter by the number of users with this media on their list where popularity is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> PopularityLesserThanArgument(int value)
        {
            return PopularityLesser.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> PopularityLesser { get; set; }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<string>> SortArgument(IEnumerable<string> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<IEnumerable<string>> Sort { get; set; }


        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            IdMyAnimeList = new GraphQLQueryArgument<int>("idMal");
            StartDate = new GraphQLQueryArgument<FuzzyDateInt>("startDate");
            EndDate = new GraphQLQueryArgument<FuzzyDateInt>("endDate");
            Season = new GraphQLQueryArgument<MediaSeason>("season");
            SeasonYear = new GraphQLQueryArgument<int>("seasonYear");
            Type = new GraphQLQueryArgument<MediaType>("type");
            Format = new GraphQLQueryArgument<MediaFormat>("format");
            Status = new GraphQLQueryArgument<MediaStatus>("status");
            Episodes = new GraphQLQueryArgument<int>("episodes");
            Duration = new GraphQLQueryArgument<int>("duration");
            Chapters = new GraphQLQueryArgument<int>("chapters");
            Volumes = new GraphQLQueryArgument<int>("volumes");
            IsAdult = new GraphQLQueryArgument<bool>("isAdult");
            Genre = new GraphQLQueryArgument<string>("genre");
            Tag = new GraphQLQueryArgument<string>("tag");
            TagCategory = new GraphQLQueryArgument<string>("tagCategory");
            OnList = new GraphQLQueryArgument<bool>("onList");
            AverageScore = new GraphQLQueryArgument<int>("averageScore");
            Popularity = new GraphQLQueryArgument<int>("popularity");
            Search = new GraphQLQueryArgument<string>("search");
            IdNot = new GraphQLQueryArgument<int>("id_not");
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in");
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in");
            IdMyAnimeListNot = new GraphQLQueryArgument<int>("idMal_not");
            IdMyAnimeListIn = new GraphQLQueryArgument<IEnumerable<int>>("idMal_in");
            IdMyAnimeListNotIn = new GraphQLQueryArgument<IEnumerable<int>>("idMal_not_in");
            StartDateGreater = new GraphQLQueryArgument<FuzzyDateInt>("startDate_greater");
            StartDateLesser = new GraphQLQueryArgument<FuzzyDateInt>("startDate_lesser");
            StartDateLike = new GraphQLQueryArgument<string>("startDate_like");
            EndDateGreater = new GraphQLQueryArgument<FuzzyDateInt>("endDate_greater");
            EndDateLesser = new GraphQLQueryArgument<FuzzyDateInt>("endDate_lesser");
            EndDateLike = new GraphQLQueryArgument<string>("endDate_like");
            EpisodesGreater = new GraphQLQueryArgument<int>("episodes_greater");
            EpisodesLesser = new GraphQLQueryArgument<int>("episodes_lesser");
            DurationGreater = new GraphQLQueryArgument<int>("duration_greater");
            DurationLesser = new GraphQLQueryArgument<int>("duration_lesser");
            ChaptersGreater = new GraphQLQueryArgument<int>("chapters_greater");
            ChaptersLesser = new GraphQLQueryArgument<int>("chapters_lesser");
            VolumesGreater = new GraphQLQueryArgument<int>("volumes_greater");
            VolumesLesser = new GraphQLQueryArgument<int>("volumes_lesser");
            GenreIn = new GraphQLQueryArgument<IEnumerable<string>>("genre_in");
            GenreNotIn = new GraphQLQueryArgument<IEnumerable<string>>("genre_not_in");
            TagIn = new GraphQLQueryArgument<IEnumerable<string>>("tag_in");
            TagNotIn = new GraphQLQueryArgument<IEnumerable<string>>("tag_not_in");
            TagCategoryIn = new GraphQLQueryArgument<IEnumerable<string>>("tagCategory_in");
            TagCategoryNotIn = new GraphQLQueryArgument<IEnumerable<string>>("tagCategory_not_in");
            AverageScoreNot = new GraphQLQueryArgument<int>("averageScore_not");
            AverageScoreGreater = new GraphQLQueryArgument<int>("averageScore_greater");
            AverageScoreLesser = new GraphQLQueryArgument<int>("averageScore_lesser");
            PopularityNot = new GraphQLQueryArgument<int>("popularity_not");
            PopularityGreater = new GraphQLQueryArgument<int>("popularity_greater");
            PopularityLesser = new GraphQLQueryArgument<int>("popularity_lesser");
            Sort = new GraphQLQueryArgument<IEnumerable<string>>("sort");
        }
    }
}
