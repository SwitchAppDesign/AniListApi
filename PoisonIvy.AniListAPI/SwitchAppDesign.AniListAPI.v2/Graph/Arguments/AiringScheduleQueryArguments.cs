using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available airing schedule query arguments.
    /// </summary>
    public class AiringScheduleQueryArguments
    {
        internal AiringScheduleQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the id of the airing schedule item.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media.
        /// </summary>
        public GraphQueryArgument<int> MediaIdQueryArgument(int value)
        {
            return MediaId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the airing episode number.
        /// </summary>
        public GraphQueryArgument<int> EpisodeQueryArgument(int value)
        {
            return Episode.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the time of airing.
        /// </summary>
        public GraphQueryArgument<int> AiringAtQueryArgument(int value)
        {
            return AiringAt.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter to episodes that have not yet aired.
        /// </summary>
        public GraphQueryArgument<bool> NotYetAiredQueryArgument(bool value)
        {
            return NotYetAired.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of the airing schedule item where id is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of the airing schedule item where id is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of the airing schedule item where id is not in the given collection. 
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media where id is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> MediaIdNotQueryArgument(int value)
        {
            return MediaIdNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media where id is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> MediaIdInQueryArgument(IEnumerable<int> value)
        {
            return MediaIdIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media where id is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> MediaIdNotInQueryArgument(IEnumerable<int> value)
        {
            return MediaIdNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> EpisodeNotQueryArgument(int value)
        {
            return EpisodeNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> EpisodeInQueryArgument(IEnumerable<int> value)
        {
            return EpisodeIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> EpisodeNotInQueryArgument(IEnumerable<int> value)
        {
            return EpisodeNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> EpisodeGreaterThanQueryArgument(int value)
        {
            return EpisodeGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is lesser than the given value;
        /// </summary>
        public GraphQueryArgument<int> EpisodeLesserThanQueryArgument(int value)
        {
            return EpisodeLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the time of airing where airing is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> AiringAtGreaterThanQueryArgument(int value)
        {
            return AiringAtGreater.GetQueryArgumentAndSetValue(value);
        }



        /// <summary>
        /// Filter by the time of airing where airing is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> AiringAtLesserThanQueryArgument(int value)
        {
            return AiringAtLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQueryArgument<IEnumerable<AiringSort>> SortQueryArgument(IEnumerable<AiringSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> MediaId { get; set; }
        private GraphQueryArgument<int> Episode { get; set; }
        private GraphQueryArgument<int> AiringAt { get; set; }
        private GraphQueryArgument<bool> NotYetAired { get; set; }
        private GraphQueryArgument<int> IdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQueryArgument<int> MediaIdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> MediaIdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> MediaIdNotIn { get; set; }
        private GraphQueryArgument<int> EpisodeNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> EpisodeIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> EpisodeNotIn { get; set; }
        private GraphQueryArgument<int> EpisodeGreater { get; set; }
        private GraphQueryArgument<int> EpisodeLesser { get; set; }
        private GraphQueryArgument<int> AiringAtGreater { get; set; }
        private GraphQueryArgument<int> AiringAtLesser { get; set; }
        private GraphQueryArgument<IEnumerable<AiringSort>> Sort { get; set; }

        // Special Query Arguments for use in other queries
        private GraphQueryArgument<int> Page { get; set; }
        private GraphQueryArgument<int> PerPage { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            MediaId = new GraphQueryArgument<int>("mediaId", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            Episode = new GraphQueryArgument<int>("episode", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            AiringAt = new GraphQueryArgument<int>("airingAt", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            NotYetAired = new GraphQueryArgument<bool>("notYetAired", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            IdNot = new GraphQueryArgument<int>("id_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            IdIn = new GraphQueryArgument<IEnumerable<int>>("id_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            IdNotIn = new GraphQueryArgument<IEnumerable<int>>("id_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            MediaIdNot = new GraphQueryArgument<int>("mediaId_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            MediaIdIn = new GraphQueryArgument<IEnumerable<int>>("mediaId_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            MediaIdNotIn = new GraphQueryArgument<IEnumerable<int>>("mediaId_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            EpisodeNot = new GraphQueryArgument<int>("episode_not", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            EpisodeIn = new GraphQueryArgument<IEnumerable<int>>("episode_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            EpisodeNotIn = new GraphQueryArgument<IEnumerable<int>>("episode_not_in", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            EpisodeGreater = new GraphQueryArgument<int>("episode_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            EpisodeLesser = new GraphQueryArgument<int>("episode_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            AiringAtGreater = new GraphQueryArgument<int>("airingAt_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            AiringAtLesser = new GraphQueryArgument<int>("airingAt_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));
            Sort = new GraphQueryArgument<IEnumerable<AiringSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.AiringSchedule }));

            Page = new GraphQueryArgument<int>("page", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
            PerPage = new GraphQueryArgument<int>("perPage", GetType(), queryType, new QueryArgumentRules(false, 25, null, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
        }
    }
}