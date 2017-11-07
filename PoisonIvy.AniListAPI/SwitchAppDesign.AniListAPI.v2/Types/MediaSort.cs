using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaSort
    {
        [Description("ID")]
        Id = 1,
        [Description("ID_DESC")]
        IdDesc = 2,
        [Description("TITLE_ROMAJI")]
        TitleRomaji = 3,
        [Description("TITLE_ROMAJI_DESC")]
        TitleRomajiDesc = 4,
        [Description("TITLE_ENGLISH")]
        TitleEnglish = 5,
        [Description("TITLE_ENGLISH_DESC")]
        TitleEnglishDesc = 6,
        [Description("TITLE_NATIVE")]
        TitleNative = 7,
        [Description("TITLE_NATIVE_DESC")]
        TitleNativeDesc = 8,
        [Description("TYPE")]
        Type = 9,
        [Description("TYPE_DESC")]
        TypeDesc = 10,
        [Description("FORMAT")]
        Format = 11,
        [Description("FORMAT_DESC")]
        FormatDesc = 12,
        [Description("START_DATE")]
        StartDate = 13,
        [Description("START_DATE_DESC")]
        StartDateDesc = 14,
        [Description("END_DATE")]
        EndDate = 15,
        [Description("END_DATE_DESC")]
        EndDateDesc = 16,
        [Description("SCORE")]
        Score = 17,
        [Description("SCORE_DESC")]
        ScoreDesc = 18,
        [Description("POPULARITY")]
        Popularity = 19,
        [Description("POPULARITY_DESC")]
        PopularityDesc = 20,
        [Description("EPISODES")]
        Episodes = 21,
        [Description("EPISODES_DESC")]
        EpisodesDesc = 22,
        [Description("DURATION")]
        Duration = 23,
        [Description("DURATION_DESC")]
        DurationDesc = 24,
        [Description("STATUS")]
        Status = 25,
        [Description("STATUS_DESC")]
        StatusDesc = 26,
        [Description("CHAPTERS")]
        Chapters = 27,
        [Description("CHAPTERS_DESC")]
        ChaptersDesc = 28,
        [Description("VOLUMES")]
        Volumes = 29,
        [Description("VOLUMES_DESC")]
        VolumesDesc = 30,
        [Description("UPDATED_AT")]
        UpdatedAt = 31,
        [Description("UPDATED_AT_DESC")]
        UpdateAtDesc = 32
    }
}
