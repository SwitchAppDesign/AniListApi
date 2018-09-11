using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaListOptions
    {
            public string scoreFormat { get; set; }
            public int rowOrder { get; set; }
            public bool useLegacyLists { get; set; }
            public MediaListTypeOptions animeList { get; set; } 
            public MediaListTypeOptions mangaList { get; set; }
    }
}
