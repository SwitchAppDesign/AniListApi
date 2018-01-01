using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    /// All pre-built queries.
    /// </summary>
    public partial class PreBuiltPageQueries
    {
        private void BasicAnimeFields(string searchPhrase)
        {
            _builder.AddField(_builder.PageQueryFields.MediaQueryField(new List<GraphQueryField>
            {
                _builder.OtherFields.Media.TitleQueryField(new List<GraphQueryField>
                {
                    _builder.OtherFields.MediaTitle.EnglishQueryField(),
                    _builder.OtherFields.MediaTitle.RomajiQueryField()
                }),
                _builder.OtherFields.Media.FormatQueryField(),
                _builder.OtherFields.Media.StatusQueryField(),
                _builder.OtherFields.Media.DescriptionQueryField(),
                _builder.OtherFields.Media.StartDateQueryField(),
                _builder.OtherFields.Media.EndDateQueryField(),
                _builder.OtherFields.Media.SeasonQueryField(),
                _builder.OtherFields.Media.EpisodesQueryField(),
                _builder.OtherFields.Media.DurationQueryField(),
                _builder.OtherFields.Media.CountryOfOriginQueryField(),
                _builder.OtherFields.Media.SourceQueryField(),
                _builder.OtherFields.Media.UpdatedAtQueryField(),
                _builder.OtherFields.Media.CoverImageQueryField(
                        fields: new List<GraphQueryField>
                        {
                            _builder.OtherFields.CoverImageData.MediumQueryField(),
                            _builder.OtherFields.CoverImageData.LargeQueryField(),
                        }),
                    _builder.OtherFields.Media.GenresQueryField(),
                    _builder.OtherFields.Media.AverageScoreQueryField(),
                    _builder.OtherFields.Media.IsAdultQueryField(),
                    _builder.OtherFields.Media.NextAiringEpisodeQueryField(
                        fields: new List<GraphQueryField>
                        {
                            _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                            _builder.OtherFields.AiringSchedule.EpisodeQueryField()
                        })
            },
            new List<object>
            {
                _builder.OtherArguments.Media.SearchArgument(searchPhrase)
            }));
        }

        private void FullAnimeFields()
        {
            _builder.AddField(_builder.PageQueryFields.MediaQueryField(new List<GraphQueryField>
            {
                _builder.OtherFields.Media.IdQueryField(),
                _builder.OtherFields.Media.IdMalQueryField(),
                _builder.OtherFields.Media.TitleQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.MediaTitle.EnglishQueryField(),
                        _builder.OtherFields.MediaTitle.RomajiQueryField(),
                        _builder.OtherFields.MediaTitle.NativeQueryField()
                    }),
                _builder.OtherFields.Media.FormatQueryField(),
                _builder.OtherFields.Media.StatusQueryField(),
                _builder.OtherFields.Media.DescriptionQueryField(),
                _builder.OtherFields.Media.StartDateQueryField(),
                _builder.OtherFields.Media.EndDateQueryField(),
                _builder.OtherFields.Media.SeasonQueryField(),
                _builder.OtherFields.Media.EpisodesQueryField(),
                _builder.OtherFields.Media.DurationQueryField(),
                _builder.OtherFields.Media.CountryOfOriginQueryField(),
                _builder.OtherFields.Media.SourceQueryField(),
                _builder.OtherFields.Media.UpdatedAtQueryField(),
                _builder.OtherFields.Media.CoverImageQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.CoverImageData.MediumQueryField(),
                        _builder.OtherFields.CoverImageData.LargeQueryField(),
                        _builder.OtherFields.Character.IdQueryField()
                    }),
                _builder.OtherFields.Media.BannerImageQueryField(),
                _builder.OtherFields.Media.GenresQueryField(),
                _builder.OtherFields.Media.SynonymsQueryField(),
                _builder.OtherFields.Media.TagsQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.MediaTag.IdQueryField(),
                        _builder.OtherFields.MediaTag.NameQueryField(),
                        _builder.OtherFields.MediaTag.DescriptionQueryField(),
                        _builder.OtherFields.MediaTag.CategoryQueryField(),
                        _builder.OtherFields.MediaTag.RankQueryField(),
                        _builder.OtherFields.MediaTag.IsGeneralSpoilerQueryField(),
                        _builder.OtherFields.MediaTag.IsMediaSpoilerQueryField(),
                        _builder.OtherFields.MediaTag.IsAdultQueryField()
                    }),
                _builder.OtherFields.Media.RelationsQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.MediaConnection.EdgesQueryField(
                            fields: new List<GraphQueryField>
                            {
                                _builder.OtherFields.MediaEdge.IdQueryField(),
                                _builder.OtherFields.MediaEdge.NodeQueryField(
                                    fields: new List<GraphQueryField>
                                    {
                                        _builder.OtherFields.Media.IdQueryField(),
                                        _builder.OtherFields.Media.TitleQueryField(
                                            fields: new List<GraphQueryField>
                                            {
                                                _builder.OtherFields.MediaTitle.EnglishQueryField(),
                                                _builder.OtherFields.MediaTitle.RomajiQueryField()
                                            }),
                                    }),
                                _builder.OtherFields.MediaEdge.RelationTypeQueryField(),
                                _builder.OtherFields.MediaEdge.IsMainStudioQueryField()

                            })
                    }),
                _builder.OtherFields.Media.CharactersQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.CharacterConnection.EdgesQueryField(
                            fields: new List<GraphQueryField>
                            {
                                _builder.OtherFields.CharacterEdge.IdQueryField(),
                                _builder.OtherFields.CharacterEdge.NodeQueryField(
                                    fields: new List<GraphQueryField>
                                    {
                                        _builder.OtherFields.Character.IdQueryField(),
                                        _builder.OtherFields.Character.NameQueryField(
                                            fields: new List<GraphQueryField>
                                            {
                                                _builder.OtherFields.Name.FirstQueryField(),
                                                _builder.OtherFields.Name.LastQueryField()
                                            })
                                    }),
                                _builder.OtherFields.CharacterEdge.RoleQueryField()
                            })
                    },
                    arguments: new List<object>
                    {
                        _builder.OtherArguments.CharacterConnection.SortQueryArgument(new[] { CharacterSort.Role })
                    }),
                _builder.OtherFields.Media.IsAdultQueryField(),
                _builder.OtherFields.Media.NextAiringEpisodeQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                        _builder.OtherFields.AiringSchedule.EpisodeQueryField()
                    }),
                _builder.OtherFields.Media.AiringScheduleQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.AiringScheduleConnection.EdgesQueryField(
                            fields: new List<GraphQueryField>
                            {
                                _builder.OtherFields.AiringScheduleEdge.IdQueryField(),
                                _builder.OtherFields.AiringScheduleEdge.NodeQueryField(
                                    fields: new List<GraphQueryField>
                                    {
                                        _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                                        _builder.OtherFields.AiringSchedule.EpisodeQueryField()
                                    }),
                            })
                    }),
                _builder.OtherFields.Media.ExternalLinksQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.MediaExternalLink.IdQueryField(),
                        _builder.OtherFields.MediaExternalLink.SiteQueryField(),
                        _builder.OtherFields.MediaExternalLink.UrlQueryField()
                    }),
                _builder.OtherFields.Media.StreamingEpisodesQueryField(
                    fields: new List<GraphQueryField>
                    {
                        _builder.OtherFields.MediaStreamingEpisode.TitleQueryField(),
                        _builder.OtherFields.MediaStreamingEpisode.ThumbnailQueryField(),
                        _builder.OtherFields.MediaStreamingEpisode.UrlQueryField(),
                        _builder.OtherFields.MediaStreamingEpisode.SiteQueryField()
                    }),
                _builder.OtherFields.Media.SiteUrlQueryField()
            }));
        }
}
}