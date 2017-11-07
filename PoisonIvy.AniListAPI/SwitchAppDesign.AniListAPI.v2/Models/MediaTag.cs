using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaTag
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int rank { get; set; }
        public bool isGeneralSpoiler { get; set; }
        public bool isMediaSpoiler { get; set; }
        public bool isAdult { get; set; }
    }
}
