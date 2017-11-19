using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    /// All pre-built queries.
    /// </summary>
    public class PreBuiltMediaQueries
    {
        private MediaQueryBuilder _builder;

        internal PreBuiltMediaQueries()
        {
        }

        public GraphQuery BasicAnimeMediaQuery(int anilistMediaId)
        {
            _builder = new MediaQueryBuilder();

            _builder.AddArgument(_builder.MediaQueryArguments.IdQueryArgument(anilistMediaId));
            _builder.AddArgument(_builder.MediaQueryArguments.TypeArgument(MediaType.Anime));

            _builder.AddField(_builder.MediaQueryFields.TitleQueryField(new List<GraphQueryField>
            {
                _builder.AdditionalAvailableFields.MediaTitle.EnglishQueryField(),
                _builder.AdditionalAvailableFields.MediaTitle.RomajiQueryField(),
            }));
            _builder.AddField(_builder.MediaQueryFields.FormatQueryField());
            _builder.AddField(_builder.MediaQueryFields.StatusQueryField());
            _builder.AddField(_builder.MediaQueryFields.DescriptionQueryField());
            _builder.AddField(_builder.MediaQueryFields.StartDateQueryField());
            _builder.AddField(_builder.MediaQueryFields.EndDateQueryField());
            _builder.AddField(_builder.MediaQueryFields.SeasonQueryField());
            _builder.AddField(_builder.MediaQueryFields.EpisodesQueryField());
            _builder.AddField(_builder.MediaQueryFields.DurationQueryField());
            _builder.AddField(_builder.MediaQueryFields.CountryOfOriginQueryField());
            _builder.AddField(_builder.MediaQueryFields.SourceQueryField());
            _builder.AddField(_builder.MediaQueryFields.UpdatedAtQueryField());
            _builder.AddField(_builder.MediaQueryFields.GenresQueryField());
            _builder.AddField(_builder.MediaQueryFields.AverageScoreQueryField());
            _builder.AddField(_builder.MediaQueryFields.IsAdultQueryField());
            _builder.AddField(_builder.MediaQueryFields.NextAiringEpisodeQueryField(new List<GraphQueryField>
            {
                _builder.AdditionalAvailableFields.AiringSchedule.AiringAtQueryField(),
                _builder.AdditionalAvailableFields.AiringSchedule.EpisodeQueryField()
            }));

            return _builder.BuildQuery();
        }
    }
}
