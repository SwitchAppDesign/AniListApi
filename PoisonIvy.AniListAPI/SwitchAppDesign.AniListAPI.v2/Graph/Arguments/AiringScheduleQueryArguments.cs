using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class AiringScheduleQueryArguments
    {
        public AiringScheduleQueryArguments()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the id of the airing schedule item.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media.
        /// </summary>
        public GraphQLQueryArgument<int> MediaIdQueryArgument(int value)
        {
            return MediaId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the airing episode number.
        /// </summary>
        public GraphQLQueryArgument<int> EpisodeQueryArgument(int value)
        {
            return Episode.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the time of airing.
        /// </summary>
        public GraphQLQueryArgument<int> AiringAtQueryArgument(int value)
        {
            return AiringAt.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter to episodes that have not yet aired.
        /// </summary>
        public GraphQLQueryArgument<bool> NotYetAiredQueryArgument(bool value)
        {
            return NotYetAired.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of the airing schedule item where id is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of the airing schedule item where id is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of the airing schedule item where id is not in the given collection. 
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media where id is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> MediaIdNotQueryArgument(int value)
        {
            return MediaIdNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media where id is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> MediaIdInQueryArgument(IEnumerable<int> value)
        {
            return MediaIdIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the id of associated media where id is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> MediaIdNotInQueryArgument(IEnumerable<int> value)
        {
            return MediaIdNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> EpisodeNotQueryArgument(int value)
        {
            return EpisodeNot.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> EpisodeInQueryArgument(IEnumerable<int> value)
        {
            return EpisodeIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> EpisodeNotInQueryArgument(IEnumerable<int> value)
        {
            return EpisodeNotIn.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> EpisodeGreaterThanQueryArgument(int value)
        {
            return EpisodeGreater.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the airing episode number where episode number is lesser than the given value;
        /// </summary>
        public GraphQLQueryArgument<int> EpisodeLesserThanQueryArgument(int value)
        {
            return EpisodeLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the time of airing where airing is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> AiringAtGreaterThanQueryArgument(int value)
        {
            return AiringAtGreater.GetQueryArgumentAndSetValue(value);
        }



        /// <summary>
        /// Filter by the time of airing where airing is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> AiringAtLesserThanQueryArgument(int value)
        {
            return AiringAtLesser.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// The order the results will be returned in.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<AiringSort>> SortQueryArgument(IEnumerable<AiringSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> MediaId { get; set; }
        private GraphQLQueryArgument<int> Episode { get; set; }
        private GraphQLQueryArgument<int> AiringAt { get; set; }
        private GraphQLQueryArgument<bool> NotYetAired { get; set; }
        private GraphQLQueryArgument<int> IdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQLQueryArgument<int> MediaIdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> MediaIdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> MediaIdNotIn { get; set; }
        private GraphQLQueryArgument<int> EpisodeNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> EpisodeIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> EpisodeNotIn { get; set; }
        private GraphQLQueryArgument<int> EpisodeGreater { get; set; }
        private GraphQLQueryArgument<int> EpisodeLesser { get; set; }
        private GraphQLQueryArgument<int> AiringAtGreater { get; set; }
        private GraphQLQueryArgument<int> AiringAtLesser { get; set; }
        private GraphQLQueryArgument<IEnumerable<AiringSort>> Sort { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            MediaId = new GraphQLQueryArgument<int>("mediaId");
            Episode = new GraphQLQueryArgument<int>("episode");
            AiringAt = new GraphQLQueryArgument<int>("airingAt");
            NotYetAired = new GraphQLQueryArgument<bool>("notYetAired");
            IdNot = new GraphQLQueryArgument<int>("id_not");
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in");
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in");
            MediaIdNot = new GraphQLQueryArgument<int>("mediaId_not");
            MediaIdIn = new GraphQLQueryArgument<IEnumerable<int>>("mediaId_in");
            MediaIdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("mediaId_not_in");
            EpisodeNot = new GraphQLQueryArgument<int>("episode_not");
            EpisodeIn = new GraphQLQueryArgument<IEnumerable<int>>("episode_in");
            EpisodeNotIn = new GraphQLQueryArgument<IEnumerable<int>>("episode_not_in");
            EpisodeGreater = new GraphQLQueryArgument<int>("episode_greater");
            EpisodeLesser = new GraphQLQueryArgument<int>("episode_lesser");
            AiringAtGreater = new GraphQLQueryArgument<int>("airingAt_greater");
            AiringAtLesser = new GraphQLQueryArgument<int>("airingAt_lesser");
            Sort = new GraphQLQueryArgument<IEnumerable<AiringSort>>("sort");
        }
    }
}