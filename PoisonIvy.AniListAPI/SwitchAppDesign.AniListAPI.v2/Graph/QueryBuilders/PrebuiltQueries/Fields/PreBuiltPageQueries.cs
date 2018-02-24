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
        private void FullAnimeFields(string searchPhrase)
        {
            var fieldList = new List<GraphQueryField>();

            fieldList.Add(_builder.OtherFields.Media.IdQueryField());
            fieldList.Add(_builder.OtherFields.Media.IdMalQueryField());
            fieldList.Add(GetTitleField());
            fieldList.Add(_builder.OtherFields.Media.FormatQueryField());
            fieldList.Add(_builder.OtherFields.Media.StatusQueryField());
            fieldList.Add(_builder.OtherFields.Media.DescriptionQueryField());
            fieldList.Add(_builder.OtherFields.Media.StartDateQueryField());
            fieldList.Add(_builder.OtherFields.Media.EndDateQueryField());
            fieldList.Add(_builder.OtherFields.Media.SeasonQueryField());
            fieldList.Add(_builder.OtherFields.Media.EpisodesQueryField());
            fieldList.Add(_builder.OtherFields.Media.DurationQueryField());
            fieldList.Add(_builder.OtherFields.Media.CountryOfOriginQueryField());
            fieldList.Add(_builder.OtherFields.Media.SourceQueryField());
            fieldList.Add(_builder.OtherFields.Media.UpdatedAtQueryField());
            fieldList.Add(GetCoverImageQueryField());
            fieldList.Add(_builder.OtherFields.Media.BannerImageQueryField());
            fieldList.Add(_builder.OtherFields.Media.GenresQueryField());
            fieldList.Add(_builder.OtherFields.Media.SynonymsQueryField());
            fieldList.Add(GetTagQueryField());
            fieldList.Add(GetRelationQueryField());
            fieldList.Add(GetCharacterQueryField());
            fieldList.Add(_builder.OtherFields.Media.IsAdultQueryField());
            fieldList.Add(GetNextAiringEpisodeQueryField());
            fieldList.Add(GetAiringScheduleQueryField());
            fieldList.Add(GetExternalLinksQueryField());
            fieldList.Add(GetStreamingEpisodesField());
            fieldList.Add(_builder.OtherFields.Media.SiteUrlQueryField());

            var argumentList = new List<object>
            {
               _builder.OtherArguments.Media.SearchArgument(searchPhrase)
            };

            var mediaQueryField = _builder.PageQueryFields.MediaQueryField(fieldList, argumentList);

            _builder.AddField(mediaQueryField);
        }

        private GraphQueryField GetStreamingEpisodesField()
        {
            var streamingEpisodesFields = new List<GraphQueryField>();

            streamingEpisodesFields.Add(_builder.OtherFields.MediaStreamingEpisode.TitleQueryField());
            streamingEpisodesFields.Add(_builder.OtherFields.MediaStreamingEpisode.ThumbnailQueryField());
            streamingEpisodesFields.Add(_builder.OtherFields.MediaStreamingEpisode.UrlQueryField());
            streamingEpisodesFields.Add(_builder.OtherFields.MediaStreamingEpisode.SiteQueryField());

            return _builder.OtherFields.Media.StreamingEpisodesQueryField(streamingEpisodesFields);
        }

        #region Fields with lists
        private GraphQueryField GetExternalLinksQueryField()
        {
            var externalLinksFields = new List<GraphQueryField>();

            externalLinksFields.Add(_builder.OtherFields.MediaExternalLink.IdQueryField());
            externalLinksFields.Add(_builder.OtherFields.MediaExternalLink.SiteQueryField());
            externalLinksFields.Add(_builder.OtherFields.MediaExternalLink.UrlQueryField());

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
            var nextAiringEpisodeFields = new List<GraphQueryField>();

            nextAiringEpisodeFields.Add(_builder.OtherFields.AiringSchedule.AiringAtQueryField()); 
            nextAiringEpisodeFields.Add(_builder.OtherFields.AiringSchedule.EpisodeQueryField()); 
           
            return _builder.OtherFields.Media.NextAiringEpisodeQueryField(nextAiringEpisodeFields);
        }

        private GraphQueryField GetCharacterQueryField()
        {
            //var characterFieldList = new List<GraphQueryField>();
            //var characterConnectionFieldList = new List<GraphQueryField>();
            //var characterEdgeFieldList = new List<GraphQueryField>();
            //var characterNodeFieldList = new List<GraphQueryField>();
            //var nameFieldList = new List<GraphQueryField>();

            //nameFieldList.Add(_builder.OtherFields.Name.FirstQueryField());
            //nameFieldList.Add(_builder.OtherFields.Name.LastQueryField());

            //characterNodeFieldList.Add(_builder.OtherFields.Character.IdQueryField());
            //characterNodeFieldList.Add(_builder.OtherFields.Character.NameQueryField(nameFieldList));

            //characterEdgeFieldList.Add(_builder.OtherFields.CharacterEdge.IdQueryField());
            //characterEdgeFieldList.Add(_builder.OtherFields.CharacterEdge.NodeQueryField(characterNodeFieldList));
            //characterEdgeFieldList.Add(_builder.OtherFields.CharacterEdge.RoleQueryField());

            //characterConnectionFieldList.Add(_builder.OtherFields.CharacterConnection.EdgesQueryField(characterEdgeFieldList));

            //characterFieldList.Add(_builder.OtherFields.Media.CharactersQueryField(
            //    fields: characterConnectionFieldList,
            //    arguments: new List<object>
            //    {
            //        _builder.OtherArguments.CharacterConnection.SortQueryArgument(new[] {CharacterSort.Role})
            //    }));

            //return _builder.OtherFields.Media.CharactersQueryField(characterFieldList);
            
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
            var relationQueryFields = new List<GraphQueryField>();
            var edgeQueryFields = new List<GraphQueryField>();
            var edgeNodeQueryFields = new List<GraphQueryField>();

            edgeNodeQueryFields.Add(_builder.OtherFields.Media.IdQueryField());
            edgeNodeQueryFields.Add(GetTitleField());

            edgeQueryFields.Add(_builder.OtherFields.MediaEdge.IdQueryField());
            edgeQueryFields.Add(_builder.OtherFields.MediaEdge.RelationTypeQueryField());
            edgeQueryFields.Add(_builder.OtherFields.MediaEdge.IsMainStudioQueryField());
            edgeQueryFields.Add(_builder.OtherFields.MediaEdge.NodeQueryField(edgeNodeQueryFields));

            relationQueryFields.Add(_builder.OtherFields.MediaConnection.EdgesQueryField(edgeQueryFields));


            return _builder.OtherFields.Media.RelationsQueryField(relationQueryFields);
        }

        private GraphQueryField GetTagQueryField()
        {
            var tagFieldList = new List<GraphQueryField>();

            tagFieldList.Add(_builder.OtherFields.MediaTag.IdQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.NameQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.DescriptionQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.CategoryQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.RankQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.IsGeneralSpoilerQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.IsMediaSpoilerQueryField());
            tagFieldList.Add(_builder.OtherFields.MediaTag.IsAdultQueryField());

            return _builder.OtherFields.Media.TagsQueryField(tagFieldList);
        }

        private GraphQueryField GetTitleField()
        {
            var titleFields = new List<GraphQueryField>();

            titleFields.Add(_builder.OtherFields.MediaTitle.EnglishQueryField());
            titleFields.Add(_builder.OtherFields.MediaTitle.RomajiQueryField());
            titleFields.Add(_builder.OtherFields.MediaTitle.NativeQueryField());

            return _builder.OtherFields.Media.TitleQueryField(titleFields);
        }

        private GraphQueryField GetCoverImageQueryField()
        {
            var coverImageFieldList = new List<GraphQueryField>();

            coverImageFieldList.Add(_builder.OtherFields.CoverImageData.MediumQueryField());
            coverImageFieldList.Add(_builder.OtherFields.CoverImageData.LargeQueryField());

            return _builder.OtherFields.Media.CoverImageQueryField(coverImageFieldList);

        }
        #endregion
    }
}
