using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available media query arguments.
    /// </summary>
    public class MediaQueryArguments
    {
        internal MediaQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the media id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id's MyAnimeList id.
        /// </summary>
        public GraphQueryArgument<int> IdMyAnimeListArgument(int value)
        {
            return IdMyAnimeList.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the start date of the media.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> StartDateArgument(FuzzyDate value)
        {
            return StartDate.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }


        /// <summary>
        /// Filter by the end date of the media.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> EndDateArgument(FuzzyDate value)
        {
            return EndDate.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }


        /// <summary>
        /// Filter by the season the media was released in.
        /// </summary>
        public GraphQueryArgument<MediaSeason> SeasonArgument(MediaSeason value)
        {
            return Season.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The year of the season (Winter 2017 would also include December 2016 releases). Requires season argument.
        /// </summary>
        public GraphQueryArgument<int> SeasonYearArgument(int value)
        {
            return SeasonYear.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's type.
        /// </summary>
        public GraphQueryArgument<MediaType> TypeArgument(MediaType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's format.
        /// </summary>
        public GraphQueryArgument<MediaFormat> FormatArgument(MediaFormat value)
        {
            return Format.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's current release status.
        /// </summary>
        public GraphQueryArgument<MediaStatus> FormatArgument(MediaStatus value)
        {
            return Status.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by amount of episodes the media has.
        /// </summary>
        public GraphQueryArgument<int> EpisodesArgument(int value)
        {
            return Episodes.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's episode length.
        /// </summary>
        public GraphQueryArgument<int> DurationArgument(int value)
        {
            return Duration.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's chapter count.
        /// </summary>
        public GraphQueryArgument<int> ChaptersArgument(int value)
        {
            return Chapters.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's volume count.
        /// </summary>
        public GraphQueryArgument<int> VolumesArgument(int value)
        {
            return Volumes.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by if the media's intended for 18+ adult audiences.
        /// </summary>
        public GraphQueryArgument<bool> IsAdultArgument(bool value)
        {
            return IsAdult.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's genres.
        /// </summary>
        public GraphQueryArgument<string> GenreArgument(Genres value)
        {
            return Genre.GetQueryArgumentAndSetValue(value.GetDescription());
        }


        /// <summary>
        /// Filter by the media's tags.
        /// </summary>
        public GraphQueryArgument<string> TagArgument(string value)
        {
            return Tag.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's tags with in a tag category.
        /// </summary>
        public GraphQueryArgument<string> TagCategoryArgument(string value)
        {
            return TagCategory.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media on the authenticated user's lists.
        /// </summary>
        public GraphQueryArgument<bool> OnListArgument(bool value)
        {
            return OnList.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's average score
        /// </summary>
        public GraphQueryArgument<int> AverageScoreArgument(int value)
        {
            return AverageScore.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the number of users with this media on their list
        /// </summary>
        public GraphQueryArgument<int> PopularityArgument(int value)
        {
            return Popularity.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by search query
        /// </summary>
        public GraphQueryArgument<string> SearchArgument(string value)
        {
            return Search.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id where media id is not equal to value.
        /// </summary>
        public GraphQueryArgument<int> IdIsNotArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id where media is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdIsInArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id where media is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdIsNotInArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id's MyAnimeList id where MyAnimeList id is not equal to value.
        /// </summary>
        public GraphQueryArgument<int> IdMyAnimeListIsNotArgument(int value)
        {
            return IdMyAnimeListNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id's MyAnimeList id where MyAnimeList is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdMyAnimeListIsInArgument(IEnumerable<int> value)
        {
            return IdMyAnimeListIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media id's MyAnimeList id where MyAnimeList is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdMyAnimeListIsNotInArgument(IEnumerable<int> value)
        {
            return IdMyAnimeListNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the start date of the media where start date is greater than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> StartDateGreaterThanArgument(FuzzyDate value)
        {
            return StartDateGreater.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }


        /// <summary>
        /// Filter by the start date of the media where start date is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> StartDateLesserThanArgument(FuzzyDate value)
        {
            return StartDateLesser.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }


        /// <summary>
        /// Filter by the start date of the media where start date is like the given fuzzy date in string form as a wildcard search 
        /// e.g, new FuzzyDate(2017,10,null) will be "201710%".
        /// </summary>
        public GraphQueryArgument<string> StartDateLikeThanArgument(FuzzyDate value)
        {
            return StartDateLike.GetQueryArgumentAndSetValue(value.GetFuzzyDateWildcardString());
        }


        /// <summary>
        /// Filter by the end date of the media where end date is greater than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> EndDateGreaterThanArgument(FuzzyDate value)
        {
            return EndDateGreater.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }


        /// <summary>
        /// Filter by the end date of the media where end date is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> EndDateLesserThanArgument(FuzzyDate value)
        {
            return EndDateLesser.GetQueryArgumentAndSetValue(value.GetFuzzyDateInt());
        }


        /// <summary>
        /// Filter by the end date of the media where end date is like the given fuzzy date in string form as a wildcard search 
        /// e.g, new FuzzyDate(2017,10,null) will be "201710%".
        /// </summary>
        public GraphQueryArgument<string> EndDateLikeArgument(FuzzyDate value)
        {
            return EndDateLike.GetQueryArgumentAndSetValue(value.GetFuzzyDateWildcardString());
        }



        /// <summary>
        /// Filter by amount of episodes the media has where total episodes is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> EpisodesGreaterThanArgument(int value)
        {
            return EpisodesGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by amount of episodes the media has where total episodes is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> EpisodesLesserThanArgument(int value)
        {
            return EpisodesLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's episode length where total duration is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> DurationGreaterThanArgument(int value)
        {
            return DurationGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's episode length where total duration is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> DurationLesserThanArgument(int value)
        {
            return DurationLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's chapter count where total chapters is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> ChaptersGreaterThanArgument(int value)
        {
            return ChaptersGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's chapter count where total chapters is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> ChaptersLesserThanArgument(int value)
        {
            return ChaptersLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's volume count where total volumes is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> VolumesGreaterThanArgument(int value)
        {
            return VolumesGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's volume count where total volumes is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> VolumesLesserThanArgument(int value)
        {
            return VolumesLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's genres where genre is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<string>> GenreInArgument(IEnumerable<string> value)
        {
            return GenreIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's genres where genre is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<string>> GenreNotInArgument(IEnumerable<string> value)
        {
            return GenreNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's tags where tags is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<string>> TagInArgument(IEnumerable<string> value)
        {
            return TagIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's tags where tags is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<string>> TagNotInArgument(IEnumerable<string> value)
        {
            return TagNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's tags with in a tag category where tag category is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<string>> TagCategoryInArgument(IEnumerable<string> value)
        {
            return TagCategoryIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's tags with in a tag category where tag category is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<string>> TagCategoryNotInArgument(IEnumerable<string> value)
        {
            return TagCategoryNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's average score is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> AverageScoreNotArgument(int value)
        {
            return AverageScoreNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's average score where average score is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> AverageScoreGreaterThanArgument(int value)
        {
            return AverageScoreGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the media's average score where average score is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> AverageScoreLesserThanArgument(int value)
        {
            return AverageScoreLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the number of users with this media on their list where popularity is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> PopularityNotQueryArgument(int value)
        {
            return PopularityNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the number of users with this media on their list where popularity is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> PopularityGreaterThanArgument(int value)
        {
            return PopularityGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the number of users with this media on their list where popularity is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> PopularityLesserThanArgument(int value)
        {
            return PopularityLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public GraphQueryArgument<IEnumerable<MediaSort>> SortArgument(IEnumerable<MediaSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> IdMyAnimeList { get; set; }
        private GraphQueryArgument<FuzzyDateInt> StartDate { get; set; }
        private GraphQueryArgument<FuzzyDateInt> EndDate { get; set; }
        private GraphQueryArgument<MediaSeason> Season { get; set; }
        private GraphQueryArgument<int> SeasonYear { get; set; }
        private GraphQueryArgument<MediaType> Type { get; set; }
        private GraphQueryArgument<MediaFormat> Format { get; set; }
        private GraphQueryArgument<MediaStatus> Status { get; set; }
        private GraphQueryArgument<int> Episodes { get; set; }
        private GraphQueryArgument<int> Duration { get; set; }
        private GraphQueryArgument<int> Chapters { get; set; }
        private GraphQueryArgument<int> Volumes { get; set; }
        private GraphQueryArgument<bool> IsAdult { get; set; }
        private GraphQueryArgument<string> Genre { get; set; }
        private GraphQueryArgument<string> Tag { get; set; }
        private GraphQueryArgument<string> TagCategory { get; set; }
        private GraphQueryArgument<bool> OnList { get; set; }
        private GraphQueryArgument<int> AverageScore { get; set; }
        private GraphQueryArgument<int> Popularity { get; set; }
        private GraphQueryArgument<string> Search { get; set; }
        private GraphQueryArgument<int> IdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQueryArgument<int> IdMyAnimeListNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdMyAnimeListIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdMyAnimeListNotIn { get; set; }
        private GraphQueryArgument<FuzzyDateInt> StartDateGreater { get; set; }
        private GraphQueryArgument<FuzzyDateInt> StartDateLesser { get; set; }
        private GraphQueryArgument<string> StartDateLike { get; set; }
        private GraphQueryArgument<FuzzyDateInt> EndDateGreater { get; set; }
        private GraphQueryArgument<FuzzyDateInt> EndDateLesser { get; set; }
        private GraphQueryArgument<string> EndDateLike { get; set; }
        private GraphQueryArgument<int> EpisodesGreater { get; set; }
        private GraphQueryArgument<int> EpisodesLesser { get; set; }
        private GraphQueryArgument<int> DurationGreater { get; set; }
        private GraphQueryArgument<int> DurationLesser { get; set; }
        private GraphQueryArgument<int> ChaptersGreater { get; set; }
        private GraphQueryArgument<int> ChaptersLesser { get; set; }
        private GraphQueryArgument<int> VolumesGreater { get; set; }
        private GraphQueryArgument<int> VolumesLesser { get; set; }
        private GraphQueryArgument<IEnumerable<string>> GenreIn { get; set; }
        private GraphQueryArgument<IEnumerable<string>> GenreNotIn { get; set; }
        private GraphQueryArgument<IEnumerable<string>> TagIn { get; set; }
        private GraphQueryArgument<IEnumerable<string>> TagNotIn { get; set; }
        private GraphQueryArgument<IEnumerable<string>> TagCategoryIn { get; set; }
        private GraphQueryArgument<IEnumerable<string>> TagCategoryNotIn { get; set; }
        private GraphQueryArgument<int> AverageScoreNot { get; set; }
        private GraphQueryArgument<int> AverageScoreGreater { get; set; }
        private GraphQueryArgument<int> AverageScoreLesser { get; set; }
        private GraphQueryArgument<int> PopularityNot { get; set; }
        private GraphQueryArgument<int> PopularityGreater { get; set; }
        private GraphQueryArgument<int> PopularityLesser { get; set; }
        private GraphQueryArgument<IEnumerable<MediaSort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdMyAnimeList = new GraphQueryArgument<int>("idMal", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            StartDate = new GraphQueryArgument<FuzzyDateInt>("startDate", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            EndDate = new GraphQueryArgument<FuzzyDateInt>("endDate", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Season = new GraphQueryArgument<MediaSeason>("season", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            SeasonYear = new GraphQueryArgument<int>("seasonYear", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Type = new GraphQueryArgument<MediaType>("type", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Format = new GraphQueryArgument<MediaFormat>("format", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Status = new GraphQueryArgument<MediaStatus>("status", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Episodes = new GraphQueryArgument<int>("episodes", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Duration = new GraphQueryArgument<int>("duration", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Chapters = new GraphQueryArgument<int>("chapters", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Volumes = new GraphQueryArgument<int>("volumes", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IsAdult = new GraphQueryArgument<bool>("isAdult", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Genre = new GraphQueryArgument<string>("genre", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Tag = new GraphQueryArgument<string>("tag", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            TagCategory = new GraphQueryArgument<string>("tagCategory", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            OnList = new GraphQueryArgument<bool>("onList", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            AverageScore = new GraphQueryArgument<int>("averageScore", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Popularity = new GraphQueryArgument<int>("popularity", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Search = new GraphQueryArgument<string>("search", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdNot = new GraphQueryArgument<int>("id_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdIn = new GraphQueryArgument<IEnumerable<int>>("id_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdNotIn = new GraphQueryArgument<IEnumerable<int>>("id_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdMyAnimeListNot = new GraphQueryArgument<int>("idMal_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdMyAnimeListIn = new GraphQueryArgument<IEnumerable<int>>("idMal_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            IdMyAnimeListNotIn = new GraphQueryArgument<IEnumerable<int>>("idMal_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            StartDateGreater = new GraphQueryArgument<FuzzyDateInt>("startDate_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            StartDateLesser = new GraphQueryArgument<FuzzyDateInt>("startDate_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            StartDateLike = new GraphQueryArgument<string>("startDate_like", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            EndDateGreater = new GraphQueryArgument<FuzzyDateInt>("endDate_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            EndDateLesser = new GraphQueryArgument<FuzzyDateInt>("endDate_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            EndDateLike = new GraphQueryArgument<string>("endDate_like", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            EpisodesGreater = new GraphQueryArgument<int>("episodes_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            EpisodesLesser = new GraphQueryArgument<int>("episodes_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            DurationGreater = new GraphQueryArgument<int>("duration_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            DurationLesser = new GraphQueryArgument<int>("duration_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            ChaptersGreater = new GraphQueryArgument<int>("chapters_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            ChaptersLesser = new GraphQueryArgument<int>("chapters_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            VolumesGreater = new GraphQueryArgument<int>("volumes_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            VolumesLesser = new GraphQueryArgument<int>("volumes_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            GenreIn = new GraphQueryArgument<IEnumerable<string>>("genre_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            GenreNotIn = new GraphQueryArgument<IEnumerable<string>>("genre_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            TagIn = new GraphQueryArgument<IEnumerable<string>>("tag_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            TagNotIn = new GraphQueryArgument<IEnumerable<string>>("tag_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            TagCategoryIn = new GraphQueryArgument<IEnumerable<string>>("tagCategory_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            TagCategoryNotIn = new GraphQueryArgument<IEnumerable<string>>("tagCategory_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            AverageScoreNot = new GraphQueryArgument<int>("averageScore_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            AverageScoreGreater = new GraphQueryArgument<int>("averageScore_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            AverageScoreLesser = new GraphQueryArgument<int>("averageScore_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PopularityNot = new GraphQueryArgument<int>("popularity_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PopularityGreater = new GraphQueryArgument<int>("popularity_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            PopularityLesser = new GraphQueryArgument<int>("popularity_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
            Sort = new GraphQueryArgument<IEnumerable<MediaSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media }));
        }
    }
}
