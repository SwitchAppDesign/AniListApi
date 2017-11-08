using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaListTypeOptions
    {
        public string[] sectionOrder { get; set; }
        public bool splitCompletedSectionByFormat { get; set; }
        public string[] customLists { get; set; }
        public string[] advancedScoring { get; set; }
        public bool advancedScoringEnabled { get; set; }
    }
}
