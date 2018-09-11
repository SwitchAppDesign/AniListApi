using System.ComponentModel;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaListSort
    {
        [Description("MEDIA_ID")]
        MediaId = 1,

        [Description("MEDIA_ID_DESC")]
        MediaIdDesc = 2,

        [Description("SCORE")]
        Score = 3,

        [Description("SCORE_DESC")]
        ScoreDesc = 4,

        [Description("STATUS")]
        Status = 5,

        [Description("STATUS_DESC")]
        StatusDesc = 6,

        [Description("PROGRESS")]
        Progress = 7,

        [Description("PROGRESS_DESC")]
        ProgressDesc = 8,

        [Description("PROGRESS_VOLUMES")]
        ProgressVolumes = 9,

        [Description("PROGRESS_VOLUMES_DESC")]
        ProgressVolumesDesc = 10,

        [Description("REPEAT")]
        Repeat = 11,

        [Description("REPEAT_DESC")]
        RepeatDesc = 12,

        [Description("PRIORITY")]
        Priority = 13,

        [Description("PRIORITY_DESC")]
        PriorityDesc = 13,

        [Description("STARTED_ON")]
        StartedOn = 14,

        [Description("STARTED_ON_DESC")]
        StartedOnDesc = 15,

        [Description("FINISHED_ON")]
        FinishedOn = 16,

        [Description("FINISHED_ON_DESC")]
        FinishedOnDesc = 17,

        [Description("ADDED_TIME")]
        AddedTime = 18,

        [Description("ADDED_TIME_DESC")]
        AddedTimeDesc = 19,

        [Description("UPDATED_TIME")]
        UpdatedTime = 20,

        [Description("UPDATED_TIME_DESC")]
        UpdatedTimeDesc = 21
    }
}