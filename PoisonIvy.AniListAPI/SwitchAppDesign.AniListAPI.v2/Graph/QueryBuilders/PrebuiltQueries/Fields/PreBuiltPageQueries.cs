using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    partial class PreBuiltPageQueries
    {
        //private int _relationQueryExecutionCount = 0;

        private void FullAnimeFields(string searchPhrase)
        {
            var fieldList = new List<GraphQueryField>
            {
                _builder.OtherFields.Media.IdQueryField(),
                _builder.OtherFields.Media.IdMalQueryField(),
                GetTitleField(),
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
                GetCoverImageQueryField(),
                _builder.OtherFields.Media.BannerImageQueryField(),
                _builder.OtherFields.Media.GenresQueryField(),
                _builder.OtherFields.Media.SynonymsQueryField(),
                GetTagQueryField(),
                GetRelationQueryField(),
                GetCharacterQueryField(),
                _builder.OtherFields.Media.IsAdultQueryField(),
                GetNextAiringEpisodeQueryField(),
                GetAiringScheduleQueryField(),
                GetExternalLinksQueryField(),
                GetStreamingEpisodesField(),
                _builder.OtherFields.Media.SiteUrlQueryField()
            };


        var argumentList = new List<object>
            {
                _builder.OtherArguments.Media.SearchArgument(searchPhrase),
                _builder.OtherArguments.Media.TypeArgument(MediaType.Anime)
            };

            var mediaQueryField = _builder.PageQueryFields.MediaQueryField(fieldList, argumentList);

            _builder.AddField(mediaQueryField);
        }

        private GraphQueryField GetStreamingEpisodesField()
        {
            var streamingEpisodesFields = new List<GraphQueryField>
            {
                _builder.OtherFields.MediaStreamingEpisode.TitleQueryField(),
                _builder.OtherFields.MediaStreamingEpisode.ThumbnailQueryField(),
                _builder.OtherFields.MediaStreamingEpisode.UrlQueryField(),
                _builder.OtherFields.MediaStreamingEpisode.SiteQueryField()
            };


            return _builder.OtherFields.Media.StreamingEpisodesQueryField(streamingEpisodesFields);
        }

        #region Fields with lists
        private GraphQueryField GetExternalLinksQueryField()
        {
            var externalLinksFields = new List<GraphQueryField>
            {
                _builder.OtherFields.MediaExternalLink.IdQueryField(),
                _builder.OtherFields.MediaExternalLink.SiteQueryField(),
                _builder.OtherFields.MediaExternalLink.UrlQueryField()
            };


            return _builder.OtherFields.Media.ExternalLinksQueryField(externalLinksFields);
        }

        private GraphQueryField GetAiringScheduleQueryField()
        {
            var airingScheduleFields = new List<GraphQueryField>();
            var airingScheduleNodeFields = new List<GraphQueryField>();
            var airingScheduleEdgeFields = new List<GraphQueryField>();

            airingScheduleNodeFields.Add(_builder.OtherFields.AiringSchedule.AiringAtQueryField());
            airingScheduleNodeFields.Add(_builder.OtherFields.AiringSchedule.EpisodeQueryField());

            airingScheduleEdgeFields.Add(_builder.OtherFields.AiringScheduleEdge.IdQueryField());
            airingScheduleEdgeFields.Add(_builder.OtherFields.AiringScheduleEdge.NodeQueryField(airingScheduleNodeFields));

            airingScheduleFields.Add(_builder.OtherFields.AiringScheduleConnection.EdgesQueryField(airingScheduleEdgeFields));

            return _builder.OtherFields.Media.AiringScheduleQueryField(airingScheduleFields);
        }

        private GraphQueryField GetNextAiringEpisodeQueryField()
        {
            var nextAiringEpisodeFields = new List<GraphQueryField>
            {
                _builder.OtherFields.AiringSchedule.AiringAtQueryField(),
                _builder.OtherFields.AiringSchedule.EpisodeQueryField()
            };


            return _builder.OtherFields.Media.NextAiringEpisodeQueryField(nextAiringEpisodeFields);
        }

        private GraphQueryField GetCharacterQueryField()
        {
            return _builder.OtherFields.Media.CharactersQueryField(
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
                });
        }

        private GraphQueryField GetRelationQueryField()
        {
            //_relationQueryExecutionCount++;

            var relationQueryFields = new List<GraphQueryField>();
            var relationEdges = new List<GraphQueryField>();

            relationEdges.Add(_builder.OtherFields.MediaEdge.IdQueryField());
            relationEdges.Add(_builder.OtherFields.MediaEdge.RelationTypeQueryField());

            //if (_relationQueryExecutionCount < 2)
            //    nodeFields.Add(GetRelationQueryField());

            relationQueryFields.Add(_builder.OtherFields.MediaConnection.EdgesQueryField(relationEdges));

            return _builder.OtherFields.Media.RelationsQueryField(relationQueryFields);
        }

        private GraphQueryField GetTagQueryField()
        {
            var tagFieldList = new List<GraphQueryField>
            {
                _builder.OtherFields.MediaTag.IdQueryField(),
                _builder.OtherFields.MediaTag.NameQueryField(),
                _builder.OtherFields.MediaTag.DescriptionQueryField(),
                _builder.OtherFields.MediaTag.CategoryQueryField(),
                _builder.OtherFields.MediaTag.RankQueryField(),
                _builder.OtherFields.MediaTag.IsGeneralSpoilerQueryField(),
                _builder.OtherFields.MediaTag.IsMediaSpoilerQueryField(),
                _builder.OtherFields.MediaTag.IsAdultQueryField()
            };


            return _builder.OtherFields.Media.TagsQueryField(tagFieldList);
        }

        private GraphQueryField GetTitleField()
        {
            var titleFields = new List<GraphQueryField>
            {
                _builder.OtherFields.MediaTitle.EnglishQueryField(),
                _builder.OtherFields.MediaTitle.RomajiQueryField(),
                _builder.OtherFields.MediaTitle.NativeQueryField()
            };


            return _builder.OtherFields.Media.TitleQueryField(titleFields);
        }

        private GraphQueryField GetCoverImageQueryField()
        {
            var coverImageFieldList = new List<GraphQueryField>
            {
                _builder.OtherFields.CoverImageData.MediumQueryField(),
                _builder.OtherFields.CoverImageData.LargeQueryField()
            };


            return _builder.OtherFields.Media.CoverImageQueryField(coverImageFieldList);

        }
        #endregion
    }
}
